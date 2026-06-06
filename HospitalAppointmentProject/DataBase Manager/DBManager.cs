using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using HospitalAppointmentSystem;

namespace DBapplication
{
    /// <summary>
    /// Central database access helper.
    ///
    /// Improvements over the original implementation:
    ///   * The connection string is read from App.config
    ///     (connectionStrings/"HospitalAppointmentSystem") instead of being
    ///     hard-coded to a specific machine. A default is used as a fallback.
    ///   * A fresh connection is opened and disposed per command (ADO.NET
    ///     pooling makes this cheap) rather than holding one connection open for
    ///     the whole application lifetime.
    ///   * New parameterized overloads (taking SqlParameter[]) let callers avoid
    ///     string concatenation and the SQL-injection risk that comes with it.
    ///     The original string-only methods are kept for backwards compatibility.
    /// </summary>
    public class DBManager
    {
        private readonly string _connectionString;

        public DBManager()
        {
            _connectionString = ResolveConnectionString();
        }

        private static string ResolveConnectionString()
        {
            var setting = ConfigurationManager.ConnectionStrings["HospitalAppointmentSystem"];
            if (setting != null && !string.IsNullOrWhiteSpace(setting.ConnectionString))
                return setting.ConnectionString;

            // Fallback so the app still runs if App.config is missing the entry.
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=HospitalAppointmentSystem;Integrated Security=True;";
        }

        /// <summary>Helper for building a parameter (maps null to DBNull).</summary>
        public static SqlParameter Param(string name, object value)
        {
            if (!name.StartsWith("@")) name = "@" + name;
            return new SqlParameter(name, value ?? DBNull.Value);
        }

        // ---- INSERT / UPDATE / DELETE ---------------------------------------

        public int ExecuteNonQuery(string query)
        {
            return ExecuteNonQuery(query, null);
        }

        public int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    if (parameters != null && parameters.Length > 0)
                        command.Parameters.AddRange(parameters);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        // ---- SELECT (result set) --------------------------------------------

        public DataTable ExecuteReader(string query)
        {
            return ExecuteReader(query, null);
        }

        public DataTable ExecuteReader(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    if (parameters != null && parameters.Length > 0)
                        command.Parameters.AddRange(parameters);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                            return null; // preserved for backwards compatibility
                        var dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // ---- SELECT (scalar) ------------------------------------------------

        public object ExecuteScalar(string query)
        {
            return ExecuteScalar(query, null);
        }

        public object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    if (parameters != null && parameters.Length > 0)
                        command.Parameters.AddRange(parameters);
                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// Kept for backwards compatibility. Connections are now opened and
        /// closed per command, so there is nothing to close here.
        /// </summary>
        public void CloseConnection()
        {
        }
    }

    public static class DataBase
    {
        public static DBManager Manager = new DBManager();
    }
}
