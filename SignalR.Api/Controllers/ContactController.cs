using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.Api.DAL.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.CategoryDto;
using SignalR.DtoLayer.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());

            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetById(id);
            
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact() 
            {
                FooterDescription=createContactDto.FooterDescription,
                Location=createContactDto.Location,
                Mail=createContactDto.Mail,
                Phone=createContactDto.Phone,
                FooterTitle=createContactDto.FooterTitle,
                OpenDays=createContactDto.OpenDays,
                OpenDaysDescription=createContactDto.OpenDaysDescription,
                OpenOurs=createContactDto.OpenOurs
            }); 

            return Ok("İletişim kısmı başarılı bir şekilde eklendi!");
        }

        

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            //mapping kullanmadan 1. yöntem
            _contactService.TUpdate(new Contact()
            {
                ContactId=updateContactDto.ContactId,
                FooterDescription = updateContactDto.FooterDescription,
                Location = updateContactDto.Location,
                Mail = updateContactDto.Mail,
                Phone = updateContactDto.Phone,
				FooterTitle = updateContactDto.FooterTitle,
				OpenDays = updateContactDto.OpenDays,
				OpenDaysDescription = updateContactDto.OpenDaysDescription,
				OpenOurs = updateContactDto.OpenOurs
			});

            return Ok("İletişim alanı güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var value= _contactService.TGetById(id);

            _contactService.TDelete(value);

            return Ok("İletişim alanı silindi");
        }
    }
}
