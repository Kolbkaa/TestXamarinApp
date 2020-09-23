using Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

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

            var json = await client.GetStringAsync(URL);

            var result = JsonConvert.DeserializeObject<IEnumerable<User>>(json);
            return result;
        }
    }
}
