using Xunit.Abstractions;

namespace AsynchronousCSharp.Tests;

public class DownloadDataTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public DownloadDataTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public async Task DownloadFromWebTest()
    {
        var downloadData = new IOBoundAsync();
        var result = await downloadData.DownloadFromWeb("https://google.com");
        _testOutputHelper.WriteLine("Result: " + result);
    }
}