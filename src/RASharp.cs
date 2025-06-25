namespace RASharp
{
    public partial class RASharp(string host, string token) : IRetroAchievements
    {
        public const string RetroAchievementsHost = "https://retroachievements.org";
        private readonly string _host = host;
        private readonly string _token = token;
        private readonly HttpClient _client = new()
        {
            BaseAddress = new Uri(host),
        };

        public static void Main(string[] args)
        {
            RASharp raClient = new("test", "some_secret");
            raClient.GetProfile();
            Console.WriteLine(raClient._token);
        }
    }
}