using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Data.SqlClient;

namespace HospitalAppointment.Data.Tests
{
    /// <summary>
    /// Executes a .sql file made of GO-separated batches against a connection,
    /// the same way sqlcmd does (ADO.NET cannot run multi-batch scripts directly).
    /// </summary>
    internal static class SqlScriptRunner
    {
        public static void Run(string connectionString, string scriptPath)
        {
            var batches = SplitOnGo(File.ReadAllText(scriptPath));
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            foreach (var batch in batches)
            {
                if (string.IsNullOrWhiteSpace(batch)) continue;
                using var cmd = new SqlCommand(batch, connection) { CommandTimeout = 120 };
                cmd.ExecuteNonQuery();
            }
        }

        private static IEnumerable<string> SplitOnGo(string script)
        {
            var batches = new List<string>();
            var current = new StringBuilder();
            using var reader = new StringReader(script);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Trim().Equals("GO", StringComparison.OrdinalIgnoreCase))
                {
                    batches.Add(current.ToString());
                    current.Clear();
                }
                else
                {
                    current.AppendLine(line);
                }
            }
            batches.Add(current.ToString());
            return batches;
        }
    }
}
