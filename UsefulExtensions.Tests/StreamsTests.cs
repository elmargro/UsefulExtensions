using System.Text;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UsefulExtensions.Streams;

namespace UsefulExtensions.StreamsTests
{
    [TestClass]
    public class StreamsTests
    {
        [TestMethod]
        public void ReadStreamToEnds_GivenStream_ReturnsStreamAsString()
        {
            // Arrange
            var streamContent = $"Test {Environment.NewLine} Test";
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(streamContent));

            // Act
            var result = stream.ReadStreamToEnd(Encoding.UTF8);

            // Assert
            result.Should().Be(streamContent);
        }

        [TestMethod]
        public void ReadStreamToEnd_GivenNullStream_ThrowsException()
        {
            // Arrange
            Stream? stream = null;

            // Act
            #pragma warning disable CS8604 // Possible null reference argument.
            Action act = () => stream.ReadStreamToEnd(null);

            // Assert
            act.Should().Throw<ArgumentNullException>();
        }
    }
}
