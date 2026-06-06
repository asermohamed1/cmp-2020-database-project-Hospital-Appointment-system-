using System;
using System.Data;
using HospitalAppointment.Data;
using Xunit;

namespace HospitalAppointment.Data.Tests
{
    /// <summary>
    /// Pure unit tests for the data layer's dependency-free logic. These run
    /// everywhere, no database required.
    /// </summary>
    public class ValidationTests
    {
        [Theory]
        [InlineData("user@example.com", true)]
        [InlineData("a.b-c@sub.domain.io", true)]
        [InlineData("no-at-sign", false)]
        [InlineData("missing@domain", false)]
        [InlineData("@nolocal.com", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsValidEmail_Works(string email, bool expected)
            => Assert.Equal(expected, Validation.IsValidEmail(email));

        [Theory]
        [InlineData('M', true)]
        [InlineData('F', true)]
        [InlineData('O', true)]
        [InlineData('X', false)]
        [InlineData('m', false)]
        public void IsValidGender_Works(char g, bool expected)
            => Assert.Equal(expected, Validation.IsValidGender(g));

        [Theory]
        [InlineData(0, true)]
        [InlineData(199, true)]
        [InlineData(-1, false)]
        [InlineData(200, false)]
        public void IsValidAge_Works(int age, bool expected)
            => Assert.Equal(expected, Validation.IsValidAge(age));

        [Fact]
        public void ToFlag_And_FromFlag_RoundTrip()
        {
            Assert.Equal('T', Validation.ToFlag(true));
            Assert.Equal('F', Validation.ToFlag(false));
            Assert.True(Validation.FromFlag("T"));
            Assert.False(Validation.FromFlag("F"));
            Assert.False(Validation.FromFlag(""));
            Assert.False(Validation.FromFlag(null));
        }

        [Fact]
        public void FormatDateTime_UsesIsoFormat()
            => Assert.Equal("2026-06-06T13:45:30",
                Validation.FormatDateTime(new DateTime(2026, 6, 6, 13, 45, 30)));
    }

    public class DatabaseParameterTests
    {
        [Fact]
        public void P_PrefixesNameWithAt()
            => Assert.Equal("@UserID", Database.P("UserID", 5).ParameterName);

        [Fact]
        public void P_KeepsExistingAtPrefix()
            => Assert.Equal("@UserID", Database.P("@UserID", 5).ParameterName);

        [Fact]
        public void P_MapsNullToDbNull()
            => Assert.Equal(DBNull.Value, Database.P("Age", null).Value);

        [Fact]
        public void P_KeepsConcreteValue()
            => Assert.Equal(42, Database.P("Age", 42).Value);

        [Fact]
        public void Out_CreatesOutputParameter()
        {
            var p = Database.Out("NewId", SqlDbType.Int);
            Assert.Equal(ParameterDirection.Output, p.Direction);
            Assert.Equal("@NewId", p.ParameterName);
        }

        [Fact]
        public void Constructor_RejectsEmptyConnectionString()
            => Assert.Throws<ArgumentException>(() => new Database(" "));
    }
}
