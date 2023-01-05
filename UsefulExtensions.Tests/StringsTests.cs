using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UsefulExtensions.Strings;

namespace UsefulExtensions.StringsTests
{
    [TestClass]
    public class StringsTests
    {
        [TestMethod]
        [DataRow(null, "")]
        [DataRow("test", "test")]
        [DataRow(" ", " ")]
        public void StringValue_ReturnsNonNullValueString(string value, string expectedValue)
        {
            // Act
            var result = value.Value();

            // Assert
            result.Should().Be(expectedValue);
        }

        [TestMethod]
        [DataRow("test", true)]
        [DataRow(null, false)]
        public void StringHasValue_ReturnsTrueIfStringHasAValue(string value, bool expectedResult)
        {
            // Act
            var result = value.HasValue();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow("test", true)]
        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow("   ", false)]
        public void StringHasValue_ReturnsTrueIfStringHasAnActualValue(string value, bool expectedResult)
        {
            // Act
            var result = value.HasActualValue();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
