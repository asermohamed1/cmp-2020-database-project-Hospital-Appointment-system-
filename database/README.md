# Database

Realistic, normalized SQL Server schema for the Hospital Appointment System,
plus seed data, views, parameterized stored procedures, and a compatibility
test that proves the legacy WinForms application still works against it.

## Files (apply in order)

| File | Purpose |
|------|---------|
| `01_schema.sql` | Tables, primary/foreign keys, CHECK/UNIQUE constraints, indexes |
| `02_seed.sql` | Realistic sample data for development, demos and tests |
| `03_views.sql` | Convenience views over common multi-table joins |
| `04_stored_procedures.sql` | Parameterized data-access API (injection-safe) |
| `tests/legacy_query_compat.sql` | Runs the *actual* SQL the desktop app emits |

## Design highlights

- **ISA hierarchies** modelled as table-per-type with cascading FKs:
  - `sysUser` → `patient` / `Doctor` / `sysAdmin` / `HospitalManager` / `PharmacyManager`
  - `Place` → `Hospital` / `Pharmacy` / `Clinic`
- **Referential integrity** on every relationship (appointments → doctor/patient,
  doctor → hospital/department, stock → medicine/pharmacy, etc.).
- **Correct data types**: `DATETIME2` for timestamps, `TIME` for opening hours,
  `DECIMAL(10,2)` for money — replacing free-text storage.
- **Constraints**: unique e-mail per user; `CHECK`s for gender (`M/F/O`) and the
  `T/F` flag columns (`IsAvailable`, `IsPaid`, `IsCured`, `ISAvailable`); age range.
- **Indexes** on every foreign key and on hot filter columns (email, appointment
  dates, names).
- **Stored procedures** generate IDs atomically inside a transaction, removing the
  `SELECT MAX(id)+1` race conditions in the legacy code, and take typed parameters
  to eliminate SQL injection.

### Backwards compatibility

The legacy desktop app issues column-less `INSERT INTO t VALUES(...)` statements,
so **column order in `01_schema.sql` is significant and must not be reordered**.
Tables whose IDs the app supplies itself keep plain `INT` primary keys; the two
tables where the app does not supply an id (`ActivityLogs`, `MedicalHistory`) use
an `IDENTITY` surrogate key, which the column-less `INSERT` transparently skips.
`tests/legacy_query_compat.sql` executes every distinct application statement to
guarantee this compatibility.

## Apply locally

With SQL Server reachable (e.g. via Docker — see `scripts/db_up.sh`):

```bash
# from the repo root
scripts/apply_db.sh            # creates HospitalAppointmentSystem and applies all scripts
```

Or manually with `sqlcmd`:

```bash
sqlcmd -S localhost -U sa -P '<password>' -Q "CREATE DATABASE HospitalAppointmentSystem"
for f in 01_schema 02_seed 03_views 04_stored_procedures; do
  sqlcmd -S localhost -U sa -P '<password>' -d HospitalAppointmentSystem -i database/$f.sql -b
done
```
