using Microsoft.AspNetCore.Mvc;
using MilkyProjectWebUI.Dtos.CategoryDtos;
using Newtonsoft.Json;

namespace MilkyProjectWebUI.Controllers
{
    public class StatisticController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> CategorCount()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7242/api/Statistic");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
             ViewBag.CategoyCount = jsonData;
                return View();     

        }
    }
}
