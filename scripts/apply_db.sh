#!/usr/bin/env bash
# Creates the HospitalAppointmentSystem database (if needed) and applies every
# script in database/ in order. Targets the SQL Server container from db_up.sh.
set -euo pipefail

CONTAINER="${MSSQL_CONTAINER:-hospital-mssql}"
PASSWORD="${MSSQL_SA_PASSWORD:-HospitalDev!2024}"
DB="${MSSQL_DATABASE:-HospitalAppointmentSystem}"
ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
SQLCMD="/opt/mssql-tools18/bin/sqlcmd"

run() { docker exec -i "${CONTAINER}" "${SQLCMD}" -S localhost -U sa -P "${PASSWORD}" -C "$@"; }

echo "Ensuring database '${DB}' exists..."
run -Q "IF DB_ID('${DB}') IS NULL CREATE DATABASE [${DB}];" -b

for f in 01_schema 02_seed 03_views 04_stored_procedures; do
  echo "Applying database/${f}.sql ..."
  docker cp "${ROOT}/database/${f}.sql" "${CONTAINER}:/tmp/${f}.sql" >/dev/null
  run -d "${DB}" -i "/tmp/${f}.sql" -b
done

echo "Running legacy-query compatibility test..."
docker cp "${ROOT}/database/tests/legacy_query_compat.sql" "${CONTAINER}:/tmp/legacy.sql" >/dev/null
run -d "${DB}" -i "/tmp/legacy.sql" -b

echo "Database ready."
