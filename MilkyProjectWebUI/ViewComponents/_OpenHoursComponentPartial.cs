using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.LocationDtos;
using MilkyProject.DtoLayer.OpenHoursDtos;
using Newtonsoft.Json;

namespace MilkyProjectWebUI.ViewComponents
{
    public class _OpenHoursComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _OpenHoursComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7242/api/OpenHours");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultOpenHoursDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
