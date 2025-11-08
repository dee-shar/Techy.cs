using System.Net.Http;

namespace TechyApi
{
    public class Techy
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://techy-api.vercel.app/api";
        public Techy()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetPhrase()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/json");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
