namespace AsynchronousCSharp;

public class IOBoundAsync
{
    public async Task<string> DownloadFromWeb(string url)
    {
        var httpClient = new HttpClient();
        var stringData = await httpClient.GetStringAsync(url);
        return stringData;
    }
}