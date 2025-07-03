
namespace RASharp.Http;

using System.Net.Http.Json;

public class Client(HttpClient client, string host, string userAgent, string token) : IDisposable
{
    private readonly HttpClient _client = client;
    private readonly string _host = host;
    private readonly string _userAgent = userAgent;
    private readonly string _token = token;

    public Request NewRequest()
    {
        Request request = new Request()
            .Host(this._host)
            .UserAgent(this._userAgent)
            .Y(this._token);
        return request;
    }

    public async Task<T?> Do<T>(Request req)
    {
        var request = req.Build();
        var response = await this._client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<T>();
    }

    public void Dispose()
    {
        this._client?.Dispose();
        GC.SuppressFinalize(this);
    }
}