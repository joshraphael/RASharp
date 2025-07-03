namespace RASharp;

using RASharp.Models;

interface IRetroAchievements
{
    public Task<GetUserProfile?> GetUserProfile(string username);
}