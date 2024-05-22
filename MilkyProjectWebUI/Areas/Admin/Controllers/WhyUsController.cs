using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.SocialMediaDtos;
using MilkyProject.DtoLayer.WhyUsDtos;
using Newtonsoft.Json;
using System.Text;

namespace MilkyProjectWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/WhyUs")]
    public class WhyUsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public WhyUsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7242/api/WhyUs");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultWhyUsDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        [Route("CreateWhyUs")]
        public IActionResult CreateWhyUs()
        {
            return View();
        }
        [HttpPost]
        [Route("CreateWhyUs")]
        public async Task<IActionResult> CreateWhyUs(CreateWhyUsDto createWhyUsDto)
        {

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createWhyUsDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7242/api/WhyUs", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [Route("DeleteWhyUs/{id}")]
        public async Task<IActionResult> DeleteWhyUs(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("https://localhost:7242/api/WhyUs?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        [Route("UpdateWhyUs/{id}")]
        public async Task<IActionResult> UpdateWhyUs(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var resposenMessage = await client.GetAsync($"https://localhost:7242/api/WhyUs/GetWhyUs?id=" + id);
            if (resposenMessage.IsSuccessStatusCode)
            {
                var jsonData = await resposenMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateWhyUsDto>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        [Route("UpdateWhyUs/{id}")]
        public async Task<IActionResult> UpdateWhyUs(UpdateWhyUsDto updateWhyUsDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateWhyUsDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7242/api/WhyUs/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
