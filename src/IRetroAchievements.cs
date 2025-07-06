namespace RASharp;

using RASharp.Models;

interface IRetroAchievements
{
    // User
    public Task<GetUserProfile?> GetUserProfile(string username);

    // Connect
    public Task<GetCodeNotes?> GetCodeNotes(int gameID);
}