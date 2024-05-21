using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessagesController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _messageService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateMessage(Message message)
        {
            message.Date = DateTime.Now;
            _messageService.TInsert(message);
            return Ok("Mesaj Başarıyla Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteMessage(int id)
        {
            _messageService.TDelete(id);
            return Ok("Mesaj Başarıyla Silindi");
        }

        [HttpPut]
        public IActionResult UpdateteMessage(Message message)
        {
            _messageService.TUpdate(message);
            return Ok("Mesaj Başarıyla Güncellendi");
        }
    }
}
