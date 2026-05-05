using App;

namespace App.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        var calculator = new Calculator();
        var result = calculator.Add(5, 7);
        Assert.Equal(12, result);
    }

    [Theory]
    [InlineData(10, 5, 5)]
    [InlineData(0, 5, -5)]
    [InlineData(-5, -5, 0)]
    public void Subtract_VariousNumbers_ReturnsCorrectDifference(int a, int b, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Subtract(a, b);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Multiply_TwoNumbers_ReturnsCorrectProduct()
    {
        var calculator = new Calculator();
        var result = calculator.Multiply(4, 3);
        Assert.Equal(12, result);
    }

    [Fact]
    public void Divide_TwoNumbers_ReturnsCorrectQuotient()
    {
        var calculator = new Calculator();
        var result = calculator.Divide(10, 2);
        Assert.Equal(5.0, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        var calculator = new Calculator();
        var exception = Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        Assert.Equal("Делить на ноль нельзя!", exception.Message);
    }
}