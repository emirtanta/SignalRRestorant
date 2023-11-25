using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.Api.DAL.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.CategoryDto;
using SignalR.DtoLayer.ContactDto;
using SignalR.DtoLayer.DiscountDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var values = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());

            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            _discountService.TAdd(new Discount() 
            {
                Amount= createDiscountDto.Amount,
                Description= createDiscountDto.Description,
                ImageIrl= createDiscountDto.ImageIrl,
                Title= createDiscountDto.Title,
                Status=false
            }); 

            return Ok("İndirim kısmı başarılı bir şekilde eklendi!");
        }

        

        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            //mapping kullanmadan 1. yöntem
            _discountService.TUpdate(new Discount()
            {
                DiscountId=updateDiscountDto.DiscountId,
                Amount = updateDiscountDto.Amount,
                Description = updateDiscountDto.Description,
                ImageIrl = updateDiscountDto.ImageIrl,
                Title = updateDiscountDto.Title,
				Status = false
			});

            return Ok("İndirim alanı güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDiscount(int id)
        {
            var value= _discountService.TGetById(id);

            _discountService.TDelete(value);

            return Ok("İndirim alanı silindi");
        }

        [HttpGet("ChangeStatusToTrue/{id}")]
        public IActionResult ChangeStatusToTrue(int id)
        {
            _discountService.TChangeStatusToTrue(id);

            return Ok("Durum Aktifleştirildi");
        }
		
		[HttpGet("ChangeStatusToFalse/{id}")]
		public IActionResult ChangeStatusToFalse(int id)
		{
			_discountService.TChangeStatusToFalse(id);

			return Ok("Durum Pasif Hale Getirildi");
		}

		[HttpGet("GetListByStatusTrue")]
		public IActionResult GetListByStatusTrue()
		{
			_discountService.TGetListByStatusTrue();

			return Ok();
		}
	}
}
