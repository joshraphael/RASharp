using RASharp;

public class Playground
{
    public static async Task Main(string[] args)
    {
        var token = Environment.GetEnvironmentVariable("RA_API_KEY") ?? "";
        var raClient = new RetroAchievements(RetroAchievements.RetroAchievementsHost, token);
        var userProfile = await raClient.GetUserProfile("joshraphael");
        Console.WriteLine(userProfile?.User);
    }
}