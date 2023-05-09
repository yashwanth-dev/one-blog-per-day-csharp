namespace AsynchronousCSharp.Tests;

public class CookTests
{
    [Fact]
    public async Task MustCook()
    {
        var cook = new Cook();
        await cook.PrepareBreakfast();
    }
}