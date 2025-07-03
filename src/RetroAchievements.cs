namespace RASharp;

using RASharp.Http;

public partial class RetroAchievements(string host, string token) : IRetroAchievements
{
    public const string RetroAchievementsHost = "https://retroachievements.org";
    private readonly string _host = host;
    private readonly string _token = token;
    private readonly Client _client = new(new HttpClient(), host, "RASharp/v0.0.0", token);
}