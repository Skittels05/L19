using MyApp;
namespace MyApp.Tests;

public class UnitTest1 {
    [Fact]
    public void TestAdd() {
        var calc = new Calculator();
        Assert.Equal(10, calc.Add(4, 6));
    }
}
