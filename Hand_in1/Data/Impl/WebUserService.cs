using System;
using System.Net.Http;
using System.Threading.Tasks;
using Hand_in1.Models;
using System.Text.Json;

namespace Hand_in1.Data.Impl
{
    public class WebUserService : IUserService
    {
        private const string Uri = "https://localhost:5003";

        private readonly HttpClient _client;

        public WebUserService()
        {
            _client = new HttpClient();
        }

        public async Task<User> ValidateUserAsync(string username, string password)
        {
            HttpResponseMessage responseMessage =
                await _client.GetAsync(Uri + $"/User?username={username}&password={password}");

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.Content.ReadAsStringAsync().Result}");

            string result = await responseMessage.Content.ReadAsStringAsync();

            User user = JsonSerializer.Deserialize<User>(result, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return user;
        }
    }
}