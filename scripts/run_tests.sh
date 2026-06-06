#!/usr/bin/env bash
# Runs the cross-platform data-layer test suite.
#   * Unit tests always run.
#   * Integration tests run when a SQL Server is reachable; otherwise they skip.
# Pass --with-db to spin up the Docker SQL Server first.
set -euo pipefail

ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
PASSWORD="${MSSQL_SA_PASSWORD:-HospitalDev!2024}"
PORT="${MSSQL_PORT:-1433}"

if [[ "${1:-}" == "--with-db" ]]; then
  "${ROOT}/scripts/db_up.sh"
  export HOSPITAL_TEST_DB_CONNECTION="Server=localhost,${PORT};Database=HospitalAppointmentSystem_Test;User Id=sa;Password=${PASSWORD};TrustServerCertificate=True;Encrypt=False"
fi

cd "${ROOT}/tests/HospitalAppointment.Data.Tests"
dotnet test
