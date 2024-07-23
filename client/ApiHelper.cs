using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace client
{
    public static class ApiHelper
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<List<Product>> GetProductsAsync(string apiUrl)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                var responseData = await response.Content.ReadAsStringAsync();
                var products = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(responseData);
                return products;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка загрузки продуктов: {ex.Message}");
            }
        }
    }
}
