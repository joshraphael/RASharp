namespace RASharp
{
    public partial class RASharp(string url) : IRetroAchievements
    {
        private readonly string _baseURL = url;

        public static void Main(string[] args)
        {
            RASharp t = new("test");
            t.GetProfile();
        }
    }
}