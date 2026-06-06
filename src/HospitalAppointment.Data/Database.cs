using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace HospitalAppointment.Data
{
    /// <summary>
    /// Lightweight, fully parameterized data-access helper and the secure
    /// replacement for the legacy <c>DBManager</c>. Every dynamic value flows
    /// through a <see cref="SqlParameter"/>, which eliminates the SQL-injection
    /// risk of string-concatenated queries. A fresh connection is opened and
    /// disposed per call; ADO.NET connection pooling makes that cheap and avoids
    /// the single shared-connection lifetime bug in the original code.
    /// </summary>
    public class Database
    {
        private readonly string _connectionString;

        public Database(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("A connection string is required.", nameof(connectionString));
            _connectionString = connectionString;
        }

        /// <summary>Builds a parameter, mapping null to <see cref="DBNull"/>.</summary>
        public static SqlParameter P(string name, object value)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Parameter name is required.", nameof(name));
            if (name[0] != '@') name = "@" + name;
            return new SqlParameter(name, value ?? DBNull.Value);
        }

        /// <summary>Builds an OUTPUT parameter of the given type.</summary>
        public static SqlParameter Out(string name, SqlDbType type)
        {
            if (name[0] != '@') name = "@" + name;
            return new SqlParameter(name, type) { Direction = ParameterDirection.Output };
        }

        public int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
            => Execute(sql, CommandType.Text, cmd => cmd.ExecuteNonQuery(), parameters);

        public object ExecuteScalar(string sql, params SqlParameter[] parameters)
            => Execute(sql, CommandType.Text, cmd => cmd.ExecuteScalar(), parameters);

        public DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
            => Execute(sql, CommandType.Text, LoadTable, parameters);

        public int ExecuteProcedure(string procedureName, params SqlParameter[] parameters)
            => Execute(procedureName, CommandType.StoredProcedure, cmd => cmd.ExecuteNonQuery(), parameters);

        public object ScalarProcedure(string procedureName, params SqlParameter[] parameters)
            => Execute(procedureName, CommandType.StoredProcedure, cmd => cmd.ExecuteScalar(), parameters);

        public DataTable QueryProcedure(string procedureName, params SqlParameter[] parameters)
            => Execute(procedureName, CommandType.StoredProcedure, LoadTable, parameters);

        private static DataTable LoadTable(SqlCommand cmd)
        {
            using (var reader = cmd.ExecuteReader())
            {
                var table = new DataTable();
                table.Load(reader);
                return table;
            }
        }

        private T Execute<T>(string commandText, CommandType type, Func<SqlCommand, T> action, SqlParameter[] parameters)
        {
            if (string.IsNullOrWhiteSpace(commandText))
                throw new ArgumentException("Command text is required.", nameof(commandText));

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(commandText, connection) { CommandType = type })
            {
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);

                connection.Open();
                return action(command);
            }
        }
    }
}
