using Codewars_ScreenLockingPatterns;
using System.ComponentModel;

namespace Codewars_ScreenLockingPatternsTests
{
    public class MethodsTests
    {
        [Theory]
        [InlineData('A', 2, 5)]
        [InlineData('C', 2, 5)]
        [InlineData('G', 2, 5)]
        [InlineData('I', 2, 5)]
        [InlineData('B', 2, 7)]
        [InlineData('D', 2, 7)]
        [InlineData('F', 2, 7)]
        [InlineData('H', 2, 7)]
        [InlineData('E', 2, 8)]
        [InlineData('A', 0, 0)]
        [InlineData('A', 10, 0)]
        [InlineData('B', 1, 1)]
        [InlineData('D', 3, 37)]
        [InlineData('A', 3, 31)]
        [InlineData('E', 4, 256)]
        [InlineData('E', 8, 23280)]
        public void CountPatternsFrom(char firstDot, int length, int expected)
        {
            // Arrange - unnecessary because it is a static method

            // Act
            var actual = Methods.CountPatternsFrom(firstDot, length);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}