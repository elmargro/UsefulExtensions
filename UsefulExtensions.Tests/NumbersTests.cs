using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UsefulExtensions.Numbers;

namespace UsefulExtensions.NumbersTests
{
    [TestClass]
    public class NumbersTests
    {
        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(7, 7)]
        [DataRow(null, 0)]
        public void Value_GivenInteger_ReturnsExpectedValue(int? value, int expectedValue)
        {
            // Act
            var result = value.Value();

            // Assert
            result.Should().Be(expectedValue);
        }

        [TestMethod]
        [DataRow(0d, 0d)]
        [DataRow(0.75d, 0.75d)]
        [DataRow(double.NaN, 0d)]
        [DataRow(null, 0d)]
        public void Value_GivenDouble_ReturnsExpectedValue(double? value, double expectedValue)
        {
            // Act
            var result = value.Value();

            // Assert
            result.Should().Be(expectedValue);
        }

        [TestMethod]
        [DataRow(0f, 0f)]
        [DataRow(134.45E-2f, 134.45E-2f)]
        [DataRow(float.NaN, 0f)]
        [DataRow(null, 0f)]
        public void Value_GivenFloat_ReturnsExpectedValue(float? value, float expectedValue)
        {
            // Act
            var result = value.Value();

            // Assert
            result.Should().Be(expectedValue);
        }

        [TestMethod]
        [DataRow(0L, 0L)]
        [DataRow(5000000000000L, 5000000000000L)]
        [DataRow(null, 0L)]
        public void Value_GivenLong_ReturnsExpectedValue(long? value, long expectedValue)
        {
            // Act
            var result = value.Value();

            // Assert
            result.Should().Be(expectedValue);
        }

        [TestMethod]
        [DataRow(0UL, 0UL)]
        [DataRow(5000000000000000000UL, 5000000000000000000UL)]
        [DataRow(null, 0UL)]
        public void Value_GivenULong_ReturnsExpectedValue(ulong? value, ulong expectedValue)
        {
            // Act
            var result = value.Value();

            // Assert
            result.Should().Be(expectedValue);
        }

        [TestMethod]
        [DataRow(10d, true)]
        [DataRow(21.3, true)]
        [DataRow(0d, true)]
        [DataRow(double.NaN, false)]
        [DataRow(null, false)]
        public void HasValue_GivenNumber_ReturnsExpectedValue(double? value, bool expectedValue)
        {
            // Act
            var result = value.HasValue();

            // Assert
            result.Should().Be(expectedValue);
        }

        [TestMethod]
        [DataRow(10d, true)]
        [DataRow(21.3, true)]
        [DataRow(0d, false)]
        [DataRow(double.NaN, false)]
        [DataRow(null, false)]
        public void HasActualValue_GivenNumber_ReturnsExpectedValue(double? value, bool expectedValue)
        {
            // Act
            var result = value.HasActualValue();

            // Assert
            result.Should().Be(expectedValue);
        }
    }
}
