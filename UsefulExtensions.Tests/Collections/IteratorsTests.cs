using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UsefulExtensions.Collections;

namespace UsefulExtensions.Tests.Collections
{
    [TestClass]
    public class IteratorsTests
    {
        [TestMethod]
        public void IEnumerableForEach_FiresActionOnEveryElement()
        {
            // Arrange
            var sourceCollection = new TestObject[]
            {
                new TestObject { TestCount = 1, TestString = "1" },
                new TestObject { TestCount = 2, TestString = "2" },
                new TestObject { TestCount = 3, TestString = "3" }
            };

            var compareCollection = GetTestIEnumerable();

            // Act
            compareCollection.ForEach(x => x.TestString += x.TestCount);

            // Assert
            sourceCollection.Should().BeEquivalentTo(compareCollection);
        }

        [TestMethod]
        public void IListForEach_FiresActionOnEveryElement()
        {
            // Arrange
            var sourceCollection = new TestObject[]
            {
                new TestObject { TestCount = 1, TestString = "1" },
                new TestObject { TestCount = 2, TestString = "2" },
                new TestObject { TestCount = 3, TestString = "3" }
            };

            var compareCollection = GetTestIList();

            // Act
            compareCollection.ForEach(x => x.TestString += x.TestCount);

            // Assert
            sourceCollection.Should().BeEquivalentTo(compareCollection);
        }

        [TestMethod]
        public void IListFor_FiresActionOnElements()
        {
            // Arrange
            var sourceCollection = new TestObject[]
            {
                new TestObject { TestCount = 1, TestString = "1" },
                new TestObject { TestCount = 2, TestString = "2" },
                new TestObject { TestCount = 3 }
            };

            var compareCollection = GetTestIList();

            // Act
            compareCollection.For(x => x.TestString += x.TestCount, 0, 1);

            // Assert
            sourceCollection.Should().BeEquivalentTo(compareCollection);
        }

        private static IList<TestObject> GetTestIList() => new TestObject[]
        {
            new TestObject { TestCount = 1 },
            new TestObject { TestCount = 2 },
            new TestObject { TestCount = 3 }
        };

        private static IEnumerable<TestObject> GetTestIEnumerable() => GetTestIList().OrderBy(x => x.TestCount);
    }
}
