using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Hand_in1.Models;

namespace Hand_in1.Data.Impl
{
    public class WebAdultService : IAdultService
    {
        private const string Uri = "https://localhost:5003";

        private readonly HttpClient _client;

        public WebAdultService()
        {
            _client = new HttpClient();
        }
        
        public async Task AddAdultAsync(Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            StringContent content = new StringContent(adultAsJson, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await _client.PostAsync(Uri + "/adults", content);
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
        }

        public async Task<Adult> GetAdultAsync(int id)
        {
            HttpResponseMessage responseMessage = await _client.GetAsync(Uri + $"/Adults/{id}");

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            string result = await responseMessage.Content.ReadAsStringAsync();

            Adult adult = JsonSerializer.Deserialize<Adult>(result, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            
            return adult;
        }

        public async Task<IList<Adult>> GetAllAdultsAsync()
        {
            HttpResponseMessage responseMessage = await _client.GetAsync(Uri + "/Adults");

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            string result = await responseMessage.Content.ReadAsStringAsync();

            List<Adult> adults = JsonSerializer.Deserialize<List<Adult>>(result, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            
            return adults;
        }

        public async Task EditAdultAsync(Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            StringContent content = new(adultAsJson, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await _client.PatchAsync(Uri + $"/adults/{adult.Id}", content);
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
        }

        public async Task RemoveAdultAsync(int id)
        {
            HttpResponseMessage responseMessage = await _client.DeleteAsync(Uri + $"/adults/{id}");
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
        }
    }
}