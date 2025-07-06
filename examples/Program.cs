using RASharp;

public class Playground
{
    public static async Task Main(string[] args)
    {
        var token = Environment.GetEnvironmentVariable("RA_API_KEY") ?? "";
        var raClient = new RetroAchievements(RetroAchievements.RetroAchievementsHost, token);
        try
        {
            var userProfile = await raClient.GetCodeNotes(4111);
            Console.WriteLine(userProfile?.CodeNotes[0]);
        }
        catch (Exception e)
        {
            Console.WriteLine("Call failed");
            Console.WriteLine(e);

        }
    }
}