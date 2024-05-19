using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.TeamDtos;
using MilkyProject.DtoLayer.TeamSocialMediaDtos;
using Newtonsoft.Json;

namespace MilkyProjectWebUI.ViewComponents
{
    public class _TeamSocialMediaComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _TeamSocialMediaComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7242/api/TeamSocialMedias/TeamSocialMediaByTeamId/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTeamSocialMediaDtos>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
