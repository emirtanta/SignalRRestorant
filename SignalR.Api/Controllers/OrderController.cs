using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult OrderList()
        {
            var values = _orderService.TGetListAll();

            return Ok(values);
        }

        //[HttpPost]
        //public IActionResult CreateOrder(CreateAboutDto createAboutDto)
        //{
        //    //mapping kullanmadan 1. yöntem
        //    About about = new About()
        //    {
        //        Title = createAboutDto.Title,
        //        Description = createAboutDto.Description,
        //        ImageUrl = createAboutDto.ImageUrl
        //    };

        //    _orderService.TAdd(about);

        //    return Ok("Hakkımda kısmı başarılı bir şekilde eklendi!");
        //}

        //[HttpGet("{id}")]
        //public IActionResult GetOrder(int id)
        //{
        //    var value= _aboutService.TGetById(id);

        //    return Ok(value);
        //}

        //[HttpPut]
        //public IActionResult UpdateOrder(UpdateAboutDto updateAboutDto)
        //{
        //    //mapping kullanmadan 1. yöntem
        //    About about = new About()
        //    {
        //        AboutId = updateAboutDto.AboutId,
        //        Title = updateAboutDto.Title,
        //        Description = updateAboutDto.Description,
        //        ImageUrl = updateAboutDto.ImageUrl
        //    };
        //    _aboutService.TUpdate(about);

        //    return Ok("Hakkımda alanı güncellendi");
        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteOrder(int id)
        //{
        //    var value=_aboutService.TGetById(id);

        //    _aboutService.TDelete(value);

        //    return Ok("Hakkımda alanı silindi");
        //}

        [HttpGet("TotalOrderCount")]
        public IActionResult TotalOrderCount()
        {
            var values = _orderService.TTotalOrderCount();

            return Ok(values); 
        }

        [HttpGet("ActiveOrderCount")]
        public IActionResult ActiveOrderCount()
        {
            var values = _orderService.TActiveOrderCount();

            return Ok(values); 
        }

        [HttpGet("LastOrderPrice")]
        public IActionResult LastOrderPrice()
        {
            var values = _orderService.TLastOrderPrice();

            return Ok(values);
        }

        [HttpGet("TodayTotalPrice")]
        public IActionResult TodayTotalPrice()
        {
            var values = _orderService.TTodayTotalPrice();

            return Ok(values);
        }
    }
}
