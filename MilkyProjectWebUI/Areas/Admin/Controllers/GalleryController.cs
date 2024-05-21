using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.ExperienceDtos;
using MilkyProject.DtoLayer.GalleryDtos;
using Newtonsoft.Json;
using System.Text;

namespace MilkyProjectWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Gallery")]
    public class GalleryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GalleryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7242/api/Galeries");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultGalleryDtos>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        [Route("UpdateGallery/{id}")]
        public async Task<IActionResult> UpdateGallery(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var resposenMessage = await client.GetAsync($"https://localhost:7242/api/Galeries/GetGallery?id=" + id);
            if (resposenMessage.IsSuccessStatusCode)
            {
                var jsonData = await resposenMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateGalleryDtos>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        [Route("UpdateGallery/{id}")]
        public async Task<IActionResult> UpdateGallery(UpdateGalleryDtos  updateGalleryDtos)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateGalleryDtos);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7242/api/Galeries/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
