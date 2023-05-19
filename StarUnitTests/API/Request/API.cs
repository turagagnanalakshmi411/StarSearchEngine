using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace StarUnitTests.API.Request
{
    [TestClass]
    public class API
    {

        private HttpClient _httpClient = new HttpClient();
        private string URI = "https://localhost:44369/api";


        [TestMethod]
        public async Task<string> TestRequest()
        {
            var builder = new System.UriBuilder($"{URI}/search?name=Katey%20Soltan&https=true");

            var response = await _httpClient.GetAsync(builder.Uri);
            var context = await response.Content.ReadAsStringAsync();
            return context;
        }
    }
}
