using RASharp.Http;
using RASharp.Models;

namespace RASharp;

public partial class RetroAchievements
{
    public GetUserProfile? GetUserProfile()
    {
        Request b = new RequestBuilder()
        .Host(this._host)
        .Build();
        return null;
    }
}