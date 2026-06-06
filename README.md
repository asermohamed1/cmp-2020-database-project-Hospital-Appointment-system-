# Hospital Appointment System

A desktop application for managing hospital appointments, built with C# Windows
Forms and SQL Server. Patients can book, edit, and cancel appointments; doctors
and admins manage schedules and view patient records. Data integrity and
efficient scheduling are provided by a normalized relational database.

## What's in this repo

| Part | Path | Tech |
|------|------|------|
| Desktop UI | `HospitalAppointmentProject/` | C# / .NET Framework 4.7.2, Windows Forms (Windows only) |
| Database | `database/` | SQL Server schema, seed data, views, stored procedures |
| Data-access library | `src/HospitalAppointment.Data/` | Cross-platform `netstandard2.0`, parameterized + repositories |
| Tests | `tests/HospitalAppointment.Data.Tests/` | xUnit (`net8.0`) — unit + integration |

## Quick start (backend / database)

Requires Docker and the .NET 8 SDK.

```bash
scripts/db_up.sh            # start SQL Server 2022 in Docker
scripts/apply_db.sh         # create the database, apply schema + seed + procs, run compat test
scripts/run_tests.sh --with-db   # run the full test suite against the database
```

See [`database/README.md`](database/README.md) for the schema design and
[`CLAUDE.md`](CLAUDE.md) for architecture and conventions.

## Running the desktop app

Open `HospitalAppointmentProject/HospitalAppointmentProject.sln` in Visual Studio
on Windows. Set the database connection in `HospitalAppointmentProject/App.config`
(`connectionStrings/"HospitalAppointmentSystem"`) to point at your SQL Server
instance, then build and run.
