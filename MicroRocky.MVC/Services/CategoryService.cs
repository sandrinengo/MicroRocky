using MicroRocky.MVC.Models.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroRocky.MVC.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategories()
        {
            var URI = "https://localhost:5001/api/category";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = new HttpResponseMessage();
            response = await _httpClient.GetAsync(URI);
            if (response != null)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    IEnumerable<CategoryDTO> categoryList = JsonConvert.DeserializeObject<List<CategoryDTO>>(result);

                    return categoryList;
                }
            }

            return null;
        }

        public async Task GetCategory(CategoryDTO categoryDTO)
        {
            var URI = "https://localhost:5001/api/category";
            var categoryContent = new StringContent(JsonConvert.SerializeObject(categoryDTO), System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(URI, categoryContent);
            string content = await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode();
        }
    }
}
