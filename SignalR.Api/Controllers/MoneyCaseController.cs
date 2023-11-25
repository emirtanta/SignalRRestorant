using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyCaseController : ControllerBase
    {
        private readonly IMoneyCaseService _moneyCaseService;

        public MoneyCaseController(IMoneyCaseService moneyCaseService)
        {
            _moneyCaseService = moneyCaseService;
        }

        [HttpGet]
        public IActionResult MoneyCaseList()
        {
            var values = _moneyCaseService.TGetListAll();

            return Ok(values);
        }

        //[HttpPost]
        //public IActionResult CreateMoneyCase(CreateAboutDto createAboutDto)
        //{
        //    //mapping kullanmadan 1. yöntem
        //    About about = new About()
        //    {
        //        Title = createAboutDto.Title,
        //        Description = createAboutDto.Description,
        //        ImageUrl = createAboutDto.ImageUrl
        //    };

        //    _moneyCaseService.TAdd(about);

        //    return Ok("Hakkımda kısmı başarılı bir şekilde eklendi!");
        //}

        //[HttpGet("{id}")]
        //public IActionResult GetMoneyCase(int id)
        //{
        //    var value= _moneyCaseService.TGetById(id);

        //    return Ok(value);
        //}

        //[HttpPut]
        //public IActionResult UpdateMoneyCase(UpdateAboutDto updateAboutDto)
        //{
        //    //mapping kullanmadan 1. yöntem
        //    About about = new About()
        //    {
        //        AboutId = updateAboutDto.AboutId,
        //        Title = updateAboutDto.Title,
        //        Description = updateAboutDto.Description,
        //        ImageUrl = updateAboutDto.ImageUrl
        //    };
        //    _moneyCaseService.TUpdate(about);

        //    return Ok("Hakkımda alanı güncellendi");
        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteMoneyCase(int id)
        //{
        //    var value= _moneyCaseService.TGetById(id);

        //    _moneyCaseService.TDelete(value);

        //    return Ok("Hakkımda alanı silindi");
        //}

        [HttpGet("TotalMoneyCaseAmount")]
        public IActionResult TotalMoneyCaseAmount()
        {
            var values = _moneyCaseService.TTotalMoneyCaseAmount();

            return Ok(values);
        }
    }
}
