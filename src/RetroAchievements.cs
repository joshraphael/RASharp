namespace RASharp;

public partial class RetroAchievements(string host, string token) : IRetroAchievements
{
    public const string RetroAchievementsHost = "https://retroachievements.org";
    private readonly string _host = host;
    private readonly string _token = token;
    private readonly HttpClient _client = new()
    {
        BaseAddress = new Uri(host),
    };

    public static void Main(string[] args) {}
}