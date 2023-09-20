# PointerClientSdk



## Example
```
public class PointerTestApiClient
{
    private readonly ITestOutputHelper _output;
    private readonly GoogleAuthorizationProvider _provider;
    private readonly HttpClientRequestAdapter _httpAdapter;

    private readonly string tenant = "xample-test";
    private readonly string key = "p2-xample-production";
    private readonly string appScope = "32555940559.apps.googleusercontent.com";
    private readonly string apiUrl = "https://garnes.pointer2.com/api";
    private readonly string filePath = ".\\wm-googlecredentialfile-00FF00FF00.json";

    public PointerTestApiClient(ITestOutputHelper output)
    {
        this._output = output;
        _provider = new GoogleAuthorizationProvider(filePath, appScope);
        _httpAdapter = new HttpClientRequestAdapter(_provider);
        _httpAdapter.BaseUrl = apiUrl;
    }

    public async Task GetArticles()
    {
        var client = new Pointer(_httpAdapter);
        var articles = await client.XrmDb.V1beta1.Tenants[tenant].Products.GetAsync();
        _output.WriteLine(articles?.ToString());
    }
}
```