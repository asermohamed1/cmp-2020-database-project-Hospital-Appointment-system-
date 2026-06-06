using System;
using System.IO;
using Microsoft.Data.SqlClient;
using Xunit;

namespace HospitalAppointment.Data.Tests
{
    /// <summary>
    /// Shared integration-test fixture. When a connection is configured via the
    /// <c>HOSPITAL_TEST_DB_CONNECTION</c> environment variable, it (re)creates a
    /// disposable test database and applies the schema, seed, views and stored
    /// procedures so every integration test runs against a known-good state.
    /// When no connection is configured, <see cref="Available"/> is false and the
    /// integration tests skip instead of failing (e.g. on a CI box with no SQL
    /// Server).
    /// </summary>
    public sealed class DatabaseFixture : IDisposable
    {
        public bool Available { get; }
        public string SkipReason { get; }
        public Database Db { get; }
        public string ConnectionString { get; }

        public DatabaseFixture()
        {
            ConnectionString = Environment.GetEnvironmentVariable("HOSPITAL_TEST_DB_CONNECTION");
            if (string.IsNullOrWhiteSpace(ConnectionString))
            {
                Available = false;
                SkipReason = "Set HOSPITAL_TEST_DB_CONNECTION to run integration tests.";
                return;
            }

            try
            {
                CreateAndSeedDatabase(ConnectionString);
                Db = new Database(ConnectionString);
                Available = true;
            }
            catch (Exception ex)
            {
                Available = false;
                SkipReason = "Could not initialize test database: " + ex.Message;
            }
        }

        private static void CreateAndSeedDatabase(string connectionString)
        {
            var builder = new SqlConnectionStringBuilder(connectionString);
            string targetDb = builder.InitialCatalog;
            if (string.IsNullOrWhiteSpace(targetDb))
                throw new InvalidOperationException("Connection string must specify an Initial Catalog.");

            // Drop & recreate the target database from the master connection.
            var masterBuilder = new SqlConnectionStringBuilder(connectionString) { InitialCatalog = "master" };
            using (var master = new SqlConnection(masterBuilder.ConnectionString))
            {
                master.Open();
                Exec(master, $@"
                    IF DB_ID('{targetDb}') IS NOT NULL
                    BEGIN
                        ALTER DATABASE [{targetDb}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                        DROP DATABASE [{targetDb}];
                    END
                    CREATE DATABASE [{targetDb}];");
            }

            var dir = LocateDatabaseScriptsDir();
            foreach (var file in new[] { "01_schema.sql", "02_seed.sql", "03_views.sql", "04_stored_procedures.sql" })
                SqlScriptRunner.Run(connectionString, Path.Combine(dir, file));
        }

        private static void Exec(SqlConnection conn, string sql)
        {
            using var cmd = new SqlCommand(sql, conn) { CommandTimeout = 120 };
            cmd.ExecuteNonQuery();
        }

        /// <summary>Walks up from the test binaries to find the repo's database/ dir.</summary>
        private static string LocateDatabaseScriptsDir()
        {
            var dir = new DirectoryInfo(AppContext.BaseDirectory);
            while (dir != null)
            {
                var candidate = Path.Combine(dir.FullName, "database");
                if (Directory.Exists(candidate) && File.Exists(Path.Combine(candidate, "01_schema.sql")))
                    return candidate;
                dir = dir.Parent;
            }
            throw new DirectoryNotFoundException("Could not locate the 'database' scripts directory.");
        }

        public void Dispose() { }
    }

    [CollectionDefinition("Database collection")]
    public sealed class DatabaseCollection : ICollectionFixture<DatabaseFixture> { }
}
