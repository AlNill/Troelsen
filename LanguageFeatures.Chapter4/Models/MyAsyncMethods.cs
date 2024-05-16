namespace LanguageFeatures.Chapter4.Models;

public class MyAsyncMethods
{
    public async static Task<long?> GetPageLehgth()
    {
        HttpClient client = new HttpClient();
        var httpTask = await client.GetAsync("http://example.com");
        return httpTask.Content.Headers.ContentLength;
    }
}
