using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UsefulExtensions.Tests.TestHelpers;

namespace UsefulExtensions.Tests
{
    [TestClass]
    public class DateTimesTests
    {
        [TestMethod]
        public void SubtractMicroseconds_GivenValueBiggerZero_SubtractsMicroseconds()
        {
            // Arrange
            var dateTime = DateTime.Parse("2018-08-18T07:22:16.0000100Z");
            var expectedDateTime = DateTime.Parse("2018-08-18T07:22:16.0000000Z");

            // Act
            var dateTimeWithSubtractedMicroseconds = dateTime.SubtractMicroseconds(10);

            // Assert
            dateTimeWithSubtractedMicroseconds.CompareTo(dateTime).Should().BeLessThan(0);
            dateTimeWithSubtractedMicroseconds.CompareToMicrosecondExtension(expectedDateTime).Should().BeTrue();
        }

        [TestMethod]
        public void SubtractMicroseconds_GivenValueLowerZero_ThrowsException()
        {
            // Arrange
            var dateTime = DateTime.UtcNow;

            // Act
            var act = () => dateTime.SubtractMicroseconds(-10);

            // Assert
            act.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        public void SubtractMilliseconds_GivenValueBiggerZero_SubtractsMilliseconds()
        {
            // Arrange
            var dateTime = DateTime.Parse("2018-08-18T07:22:16.1000000Z");
            var expectedDateTime = DateTime.Parse("2018-08-18T07:22:16.0000000Z");

            // Act
            var dateTimeWithSubtractedMilliseconds = dateTime.SubtractMilliseconds(100);

            // Assert
            dateTimeWithSubtractedMilliseconds.CompareTo(dateTime).Should().BeLessThan(0);
            dateTimeWithSubtractedMilliseconds.CompareToMicrosecondExtension(expectedDateTime).Should().BeTrue();
        }

        [TestMethod]
        public void SubtractMilliseconds_GivenValueLowerZero_ThrowsException()
        {
            // Arrange
            var dateTime = DateTime.UtcNow;

            // Act
            var act = () => dateTime.SubtractMilliseconds(-10);

            // Assert
            act.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        public void SubtractSeconds_GivenValueBiggerZero_SubtractsSeconds()
        {
            // Arrange
            var dateTime = DateTime.Parse("2018-08-18T07:22:16.0000000Z");
            var expectedDateTime = DateTime.Parse("2018-08-18T07:22:06.0000000Z");

            // Act
            var dateTimeWithSubtractedSeconds = dateTime.SubtractSeconds(10);

            // Assert
            dateTimeWithSubtractedSeconds.CompareTo(dateTime).Should().BeLessThan(0);
            dateTimeWithSubtractedSeconds.CompareToMicrosecondExtension(expectedDateTime).Should().BeTrue();
        }

        [TestMethod]
        public void SubtractSeconds_GivenValueLowerZero_ThrowsException()
        {
            // Arrange
            var dateTime = DateTime.UtcNow;

            // Act
            var act = () => dateTime.SubtractSeconds(-10);

            // Assert
            act.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        public void SubtractMinutes_GivenValueBiggerZero_SubtractsMinutes()
        {
            // Arrange
            var dateTime = DateTime.Parse("2018-08-18T07:22:16.0000000Z");
            var expectedDateTime = DateTime.Parse("2018-08-18T07:12:16.0000000Z");

            // Act
            var dateTimeWithSubtractedMinutes = dateTime.SubtractMinutes(10);

            // Assert
            dateTimeWithSubtractedMinutes.CompareTo(dateTime).Should().BeLessThan(0);
            dateTimeWithSubtractedMinutes.CompareToMicrosecondExtension(expectedDateTime).Should().BeTrue();
        }

        [TestMethod]
        public void SubtractMinutes_GivenValueLowerZero_ThrowsException()
        {
            // Arrange
            var dateTime = DateTime.UtcNow;

            // Act
            var act = () => dateTime.SubtractMinutes(-10);

            // Assert
            act.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        public void SubtractHours_GivenValueBiggerZero_SubtractsHours()
        {
            // Arrange
            var dateTime = DateTime.Parse("2018-08-18T07:22:16.0000000Z");
            var expectedDateTime = DateTime.Parse("2018-08-18T02:22:16.0000000Z");

            // Act
            var dateTimeWithSubtractedHours = dateTime.SubtractHours(5);

            // Assert
            dateTimeWithSubtractedHours.CompareTo(dateTime).Should().BeLessThan(0);
            dateTimeWithSubtractedHours.CompareToMicrosecondExtension(expectedDateTime).Should().BeTrue();
        }

        [TestMethod]
        public void SubtractHours_GivenValueLowerZero_ThrowsException()
        {
            // Arrange
            var dateTime = DateTime.UtcNow;

            // Act
            var act = () => dateTime.SubtractHours(-10);

            // Assert
            act.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        public void SubtractDays_GivenValueBiggerZero_SubtractsDays()
        {
            // Arrange
            var dateTime = DateTime.Parse("2018-08-18T07:22:16.0000000Z");
            var expectedDateTime = DateTime.Parse("2018-08-08T07:22:16.0000000Z");

            // Act
            var dateTimeWithSubtractedDays = dateTime.SubtractDays(10);

            // Assert
            dateTimeWithSubtractedDays.CompareTo(dateTime).Should().BeLessThan(0);
            dateTimeWithSubtractedDays.CompareToMicrosecondExtension(expectedDateTime).Should().BeTrue();
        }

        [TestMethod]
        public void SubtractDays_GivenValueLowerZero_ThrowsException()
        {
            // Arrange
            var dateTime = DateTime.UtcNow;

            // Act
            var act = () => dateTime.SubtractDays(-10);

            // Assert
            act.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        public void SubtractMonths_GivenValueBiggerZero_SubtractsMonths()
        {
            // Arrange
            var dateTime = DateTime.Parse("2018-08-18T07:22:16.0000000Z");
            var expectedDateTime = DateTime.Parse("2017-10-18T07:22:16.0000000Z");

            // Act
            var dateTimeWithSubtractedMonths = dateTime.SubtractMonths(10);

            // Assert
            dateTimeWithSubtractedMonths.CompareTo(dateTime).Should().BeLessThan(0);
            dateTimeWithSubtractedMonths.CompareToMicrosecondExtension(expectedDateTime).Should().BeTrue();
        }

        [TestMethod]
        public void SubtractMonths_GivenValueLowerZero_ThrowsException()
        {
            // Arrange
            var dateTime = DateTime.UtcNow;

            // Act
            var act = () => dateTime.SubtractMonths(-10);

            // Assert
            act.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        public void SubtractYears_GivenValueBiggerZero_SubtractsYears()
        {
            // Arrange
            var dateTime = DateTime.Parse("2018-08-18T07:22:16.0000000Z");
            var expectedDateTime = DateTime.Parse("2008-08-18T07:22:16.0000000Z");

            // Act
            var dateTimeWithSubtractedYears = dateTime.SubtractYears(10);

            // Assert
            dateTimeWithSubtractedYears.CompareTo(dateTime).Should().BeLessThan(0);
            dateTimeWithSubtractedYears.CompareToMicrosecondExtension(expectedDateTime).Should().BeTrue();
        }

        [TestMethod]
        public void SubstractYears_GivenValueLowerZero_ThrowsException()
        {
            // Arrange
            var dateTime = DateTime.UtcNow;

            // Act
            var act = () => dateTime.SubtractYears(-10);

            // Assert
            act.Should().Throw<ArgumentException>();
        }
    }
}
