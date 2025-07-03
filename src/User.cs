namespace RASharp;

using RASharp.Http;
using RASharp.Models;

public partial class RetroAchievements
{
    public async Task<GetUserProfile?> GetUserProfile(string username)
    {
        Request b = this._client.NewRequest()
            .HTTPMethod(HttpMethod.Get)
            .Path("/API/API_GetUserProfile.php")
            .U(username);
        var response = await this._client.Do<GetUserProfile>(b);
        // Console.WriteLine(response.User);
        return response;
    }
}