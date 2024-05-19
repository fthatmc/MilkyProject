using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.AboutDtos;
using MilkyProject.DtoLayer.AboutServiceDtos;
using Newtonsoft.Json;
using System.Net.Http;

namespace MilkyProjectWebUI.ViewComponents
{
    public class _AboutServiceComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutServiceComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7242/api/AboutServices");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutService>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
