using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.MessageDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
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
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            //mapping kullanmadan 1. yöntem
            Message message = new Message()
            {
                Mail = createMessageDto.Mail,
                MessageContent = createMessageDto.MessageContent,
                SendDate = DateTime.Now,
                NameSurname=createMessageDto.NameSurname,
                PhoneNumber=createMessageDto.PhoneNumber,
                Subject=createMessageDto.Subject,
                Status=false
            };

			_messageService.TAdd(message);

            return Ok("Mesaj başarılı bir şekilde eklendi!");
        }

        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var value= _messageService.TGetById(id);

            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
			//mapping kullanmadan 1. yöntem
			Message message = new Message()
			{
                MessageId=updateMessageDto.MessageId,
				Mail = updateMessageDto.Mail,
				MessageContent = updateMessageDto.MessageContent,
				SendDate = updateMessageDto.SendDate,
				NameSurname = updateMessageDto.NameSurname,
				PhoneNumber = updateMessageDto.PhoneNumber,
				Subject = updateMessageDto.Subject,
				Status = false
			};
			_messageService.TUpdate(message);

            return Ok("Mesaj bilgisi güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var value= _messageService.TGetById(id);

			_messageService.TDelete(value);

            return Ok("Mesaj silindi");
        }
    }
}
