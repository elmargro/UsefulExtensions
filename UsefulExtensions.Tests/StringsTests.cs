using System.Text;
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
        public void StringValue_ReturnsNonNullValueString(string? value, string expectedValue)
        {
            // Act
            var result = value.Value();

            // Assert
            result.Should().Be(expectedValue);
        }

        [TestMethod]
        [DataRow("test", true)]
        [DataRow(null, false)]
        public void StringHasValue_ReturnsTrueIfStringHasAValue(string? value, bool expectedResult)
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
        public void StringHasValue_ReturnsTrueIfStringHasAnActualValue(string? value, bool expectedResult)
        {
            // Act
            var result = value.HasActualValue();

            // Assert
            result.Should().Be(expectedResult);
        }

        [TestMethod]
        public void AsStream_GivenValueThatIsNotNull_GeneratesStream()
        {
            // Arrange
            var value = "Test";

            // Act
            var result = value.AsStream();

            // Assert
            var readStream = ReadStreamToEnd(result);

            value.Should().Be(readStream);
        }

        [TestMethod]
        public void AsStream_GivenValueAndEncoding_GeneratesStreamWithComparableContent()
        {
            // Arrange
            var value = "Test ÜÖÄ";

            // Act
            var result = value.AsStream(Encoding.UTF8);

            // Assert
            var readStream = ReadStreamToEnd(result, Encoding.UTF8);

            value.Should().Be(readStream);
        }

        [TestMethod]
        public void AsStream_GivenValueAndEncoding_GeneratesStreamWithUncomparableContent()
        {
            // Arrange
            var value = "Test ÜÖÄ";

            // Act
            var result = value.AsStream(Encoding.UTF8);

            // Assert
            var readStream = ReadStreamToEnd(result, Encoding.ASCII);

            value.Should().NotBe(readStream);
        }

        [TestMethod]
        public void AsStream_GivenNullString_ThrowsException()
        {
            // Arrange
            string? testString = null;

            // Act
            #pragma warning disable CS8604 // Possible null reference argument.
            var act = () => testString.AsStream();

            // Assert
            act.Should().Throw<ArgumentNullException>();
        }

        private static string ReadStreamToEnd(Stream stream, Encoding? encoding = null)
        {
            encoding ??= Encoding.UTF8;

            using var reader = new StreamReader(stream, encoding);
            return reader.ReadToEnd();
        }
    }
}
