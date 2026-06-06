using System;
using System.Text.RegularExpressions;

namespace HospitalAppointment.Data
{
    /// <summary>
    /// Pure, dependency-free validation helpers shared by the data layer and the
    /// UI. Kept side-effect free so they are trivially unit-testable without a
    /// database connection.
    /// </summary>
    public static class Validation
    {
        private static readonly Regex EmailRegex =
            new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

        public static bool IsValidEmail(string email)
            => !string.IsNullOrWhiteSpace(email) && EmailRegex.IsMatch(email);

        public static bool IsValidGender(char gender)
            => gender == 'M' || gender == 'F' || gender == 'O';

        public static bool IsValidAge(int age) => age >= 0 && age < 200;

        /// <summary>The schema stores boolean flags as the chars 'T'/'F'.</summary>
        public static char ToFlag(bool value) => value ? 'T' : 'F';

        public static bool FromFlag(string value)
            => !string.IsNullOrEmpty(value) &&
               (value[0] == 'T' || value[0] == 't' || value[0] == '1');

        /// <summary>The date/time format the legacy schema and app exchange.</summary>
        public const string DateTimeFormat = "yyyy-MM-ddTHH:mm:ss";

        public static string FormatDateTime(DateTime value)
            => value.ToString(DateTimeFormat, System.Globalization.CultureInfo.InvariantCulture);
    }
}
