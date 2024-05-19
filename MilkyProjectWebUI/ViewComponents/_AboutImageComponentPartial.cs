using Microsoft.AspNetCore.Mvc;
using MilkyProject.DataAccessLayer.Context;
using MilkyProject.DtoLayer.AboutImagesDtos;
using MilkyProject.DtoLayer.AboutServiceDtos;
using Newtonsoft.Json;

namespace MilkyProjectWebUI.ViewComponents
{
    public class _AboutImageComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        MilkyContext contex = new MilkyContext();

        public _AboutImageComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.years = contex.Experiences.Where(x => x.Title == "Yıl Deneyim").Select(x => x.Count).FirstOrDefault();

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7242/api/AboutImages");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutImagesDto>>(jsonData);
                return View(values);
            }

            

            return View();

           

        }
    }
}
