using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Hand_in1.Models;
using System.Text.Json;

namespace Hand_in1.Data.Impl
{
    public class WebUserService : IUserService
    {
        // public async Task<User> ValidateLogin(string username, string password)
        // {
        //     HttpClient client = new HttpClient();
        //     HttpResponseMessage response =
        //         await client.GetAsync($"https://localhost:5003/User?username={username}&password={password}");
        //     if (response.StatusCode == HttpStatusCode.OK)
        //     {
        //         string userAsJson = await response.Content.ReadAsStringAsync();
        //         User resultUser = JsonSerializer.Deserialize<User>(userAsJson);
        //         return resultUser;
        //     } 
        //
        //     throw new Exception("User not found");
        // }
        
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