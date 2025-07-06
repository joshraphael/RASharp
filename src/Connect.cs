namespace RASharp;

using RASharp.Http;
using RASharp.Models;

public partial class RetroAchievements
{
    public async Task<GetCodeNotes?> GetCodeNotes(int gameID)
    {
        Request b = this._client.NewRequest()
            .HTTPMethod(HttpMethod.Get)
            .Path("/dorequest.php")
            .G(gameID)
            .R("codenotes2");
        var response = await this._client.Do<GetCodeNotes>(b);
        return response;
    }
}