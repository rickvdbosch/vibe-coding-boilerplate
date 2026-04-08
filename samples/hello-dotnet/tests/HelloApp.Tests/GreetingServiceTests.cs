namespace HelloApp.Tests;

public class GreetingServiceTests
{
    [Fact]
    public void SayHello_WithNameNull_ReturnsDefaultGreeting()
    {
        string result = GreetingService.SayHello(null);

        Assert.Equal("Hello, world!", result);
    }

    [Fact]
    public void SayHello_WithName_ReturnsPersonalizedGreeting()
    {
        string result = GreetingService.SayHello("TechFest");

        Assert.Equal("Hello, TechFest!", result);
    }
}
