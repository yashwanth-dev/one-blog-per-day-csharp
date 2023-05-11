using System.Threading.Channels;
using Xunit.Abstractions;

namespace AsynchronousCSharp.Tests;

public class CPUBoundAsyncTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public CPUBoundAsyncTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public async Task CalculateDamageTest()
    {
        var cpuBoundAsync = new CPUBoundAsync();
        var result = await cpuBoundAsync.CalculateDamageDone();
        _testOutputHelper.WriteLine(result);
    }
}