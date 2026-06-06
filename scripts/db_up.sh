#!/usr/bin/env bash
# Starts a local SQL Server 2022 container for development and tests.
# Requires Docker. The password and port can be overridden via env vars.
set -euo pipefail

CONTAINER="${MSSQL_CONTAINER:-hospital-mssql}"
PASSWORD="${MSSQL_SA_PASSWORD:-HospitalDev!2024}"
PORT="${MSSQL_PORT:-1433}"
IMAGE="mcr.microsoft.com/mssql/server:2022-latest"

if docker ps --format '{{.Names}}' | grep -q "^${CONTAINER}$"; then
  echo "SQL Server container '${CONTAINER}' is already running."
  exit 0
fi

docker rm -f "${CONTAINER}" >/dev/null 2>&1 || true
echo "Starting SQL Server container '${CONTAINER}' on port ${PORT}..."
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=${PASSWORD}" \
  -p "${PORT}:1433" --name "${CONTAINER}" -d "${IMAGE}" >/dev/null

echo -n "Waiting for SQL Server to accept connections"
for _ in $(seq 1 40); do
  if docker exec "${CONTAINER}" /opt/mssql-tools18/bin/sqlcmd \
       -S localhost -U sa -P "${PASSWORD}" -C -Q "SELECT 1" >/dev/null 2>&1; then
    echo " ready."
    exit 0
  fi
  echo -n "."
  sleep 2
done

echo
echo "ERROR: SQL Server did not become ready in time." >&2
exit 1
