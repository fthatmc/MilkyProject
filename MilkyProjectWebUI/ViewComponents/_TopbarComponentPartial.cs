using Microsoft.AspNetCore.Mvc;
using MilkyProject.DataAccessLayer.Context;
using MilkyProject.DtoLayer.SocialMediaDtos;
using Newtonsoft.Json;

namespace MilkyProjectWebUI.ViewComponents
{
    public class _TopbarComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        MilkyContext contex = new MilkyContext();

        public _TopbarComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            ViewBag.call= contex.Locations.Select(x=>x.Call).FirstOrDefault();
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7242/api/SocialMedias");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<SocialMediaDtos>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
