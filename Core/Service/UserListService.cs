using Core.Model;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Core.Service
{
    public class UserListService : IUserListService
    {
        private const string URL = "https://jsonplaceholder.typicode.com/users";
        public async Task<IEnumerable<User>> GetUserListFromApi()
        {
            using var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            var streamTask = client.GetStreamAsync(URL);
            var response = await JsonSerializer.DeserializeAsync<IEnumerable<User>>(await streamTask);

            return response;
        }
    }
}
