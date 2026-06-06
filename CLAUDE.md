# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

A hospital appointment management system. It has two parts:

1. **Desktop app** (`HospitalAppointmentProject/`) — a **C# / .NET Framework 4.7.2 + Windows Forms** UI. Windows-only; builds in Visual Studio.
2. **Backend** (`database/`, `src/`, `tests/`) — a realistic, normalized **SQL Server** schema plus a cross-platform **.NET data-access library** and a test suite. This part builds and tests on any OS with the .NET SDK.

## Repository Layout

| Path | What it is |
|------|------------|
| `HospitalAppointmentProject/` | Legacy WinForms app (Forms, UML domain models, `DataBase Manager/DBManager.cs`) |
| `database/` | SQL Server scripts: `01_schema.sql`, `02_seed.sql`, `03_views.sql`, `04_stored_procedures.sql`, `tests/legacy_query_compat.sql` |
| `src/HospitalAppointment.Data/` | Cross-platform (`netstandard2.0`) parameterized data-access library + repositories |
| `tests/HospitalAppointment.Data.Tests/` | xUnit unit + integration tests (`net8.0`) |
| `scripts/` | `db_up.sh` (Docker SQL Server), `apply_db.sh` (create+apply schema), `run_tests.sh` |
| `HospitalAppointment.Backend.sln` | Solution for the data library + tests |

## Common Commands

```bash
# Start a local SQL Server (Docker) and apply the schema + seed + procs
scripts/db_up.sh
scripts/apply_db.sh

# Run the backend test suite (unit tests always; integration tests need a DB)
scripts/run_tests.sh            # unit only if no DB configured
scripts/run_tests.sh --with-db  # spins up Docker SQL Server, runs everything

# Run tests directly
dotnet test                                   # from repo root (uses the .sln)
dotnet test --filter FullyQualifiedName~ValidationTests   # a single test class
```

Integration tests connect using the `HOSPITAL_TEST_DB_CONNECTION` environment
variable. When it is unset (or the DB is unreachable) the integration tests
**skip** via `[SkippableFact]` and the unit tests still run. The fixture
(`DatabaseFixture`) drops and recreates the target database and re-applies all
`database/*.sql` scripts before each test run, so tests start from a known state.

The **WinForms app** (`HospitalAppointmentProject/`) is **Windows-only** and is
built/run from Visual Studio — it cannot be compiled with the cross-platform
`dotnet` CLI or on Linux/macOS.

## Architecture

### Data access — three layers, one schema

- **Legacy path:** Forms call `DataBase.Manager.Execute*` (`DBManager.cs`). `DBManager` now reads its connection string from `App.config` (`connectionStrings/"HospitalAppointmentSystem"`), opens a connection per command, and exposes **parameterized overloads** (`Execute*(sql, params SqlParameter[])`) alongside the original string-only methods kept for backward compatibility.
- **Modern path:** `src/HospitalAppointment.Data` — `Database` (parameterized helper, `Database.P(name, value)` for parameters) + repository classes (`UserRepository`, `DoctorRepository`, `AppointmentRepository`, `PharmacyRepository`) that call the stored procedures in `database/04_stored_procedures.sql`.
- **Stored procedures** are the injection-safe API: they take typed parameters and generate IDs atomically in a transaction (replacing the legacy `SELECT MAX(id)+1` pattern).

### Domain model (table-per-type ISA hierarchies)

- `sysUser` → `patient` / `Doctor` / `sysAdmin` / `HospitalManager` / `PharmacyManager`
- `Place` → `Hospital` / `Pharmacy` / `Clinic`

The C# domain classes mirroring these live in `HospitalAppointmentProject/UML/`.

## Critical Conventions

- **Column order in `database/01_schema.sql` is load-bearing.** The legacy app
  emits column-less `INSERT INTO t VALUES(...)`, so reordering a table's columns
  breaks it. After any schema change, run `database/tests/legacy_query_compat.sql`
  (executed automatically by `scripts/apply_db.sh`) — it runs every statement the
  app actually issues and must pass.
- Tables where the app supplies the id use plain `INT` primary keys. Only
  `ActivityLogs` and `MedicalHistory` use `IDENTITY` (the app doesn't supply
  their ids, and the column-less `INSERT` skips identity columns).
- Boolean flags are stored as the chars `'T'`/`'F'` (`IsAvailable`, `IsPaid`,
  `IsCured`, `ISAvailable`); gender is `'M'`/`'F'`/`'O'`. These are enforced by
  `CHECK` constraints — use `Validation.ToFlag`/`FromFlag` in C#.
- `Medicine.Active_Ingredinet` is intentionally misspelled to match the
  application's queries; do not "correct" it without updating the app.
- Designer files (`*.Designer.cs`) are auto-generated — edit the matching
  `*.cs` form instead.

## Notes

- The schema/types in `database/` were reverse-engineered to exactly match the
  table and column names the app uses (see `FinalErDiagram.pdf` / `schema.pdf`),
  then normalized with real foreign keys, indexes, and constraints.
- Passwords are stored as plaintext to match the legacy app's comparison logic;
  hashing would require corresponding app changes.
