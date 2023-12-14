using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        int position = 5;
        // Act
        string result = StringRotator.RotateRight(input, position);
        // Assert
        Assert.AreEqual(input, result);

    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "Denis";
        int position = 0;
        // Act
        string result = StringRotator.RotateRight(input, position);
        // Assert
        Assert.AreEqual(input, result);
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "Denis";
        int position = 4;
        // Act
        string result = StringRotator.RotateRight(input, position);
        // Assert
        Assert.AreEqual("enisD", result);
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "Denis";
        int position = -3;
        string expected = "nisDe";
        // Act
        string result = StringRotator.RotateRight(input, position);
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "Denis";
        int position = 2 + (input.Length * 2);
        string expected = "isDen";
        // Act
        string result = StringRotator.RotateRight(input, position);
        // Assert
        Assert.AreEqual(expected, result);
    }
}
