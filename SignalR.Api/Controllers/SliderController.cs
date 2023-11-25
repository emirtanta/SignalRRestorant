using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.Api.DAL.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.CategoryDto;
using SignalR.DtoLayer.ContactDto;
using SignalR.DtoLayer.DiscountDto;
using SignalR.DtoLayer.FeatureDto;
using SignalR.DtoLayer.SliderDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;

        public SliderController(ISliderService sliderService, IMapper mapper)
        {
            _sliderService = sliderService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SliderList()
        {
            var values = _mapper.Map<List<ResultFeatureDto>>(_sliderService.TGetListAll());

            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetSlider(int id)
        {
            var value = _sliderService.TGetById(id);
            
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateSlider(CreateSliderDto createSliderDto)
        {
            _sliderService.TAdd(new Slider() 
            {
                Title1= createSliderDto.Title1,
                Description1= createSliderDto.Description1,
                Title2= createSliderDto.Title2,
                Description2= createSliderDto.Description2,
                Title3= createSliderDto.Title3,
                Description3= createSliderDto.Description3
            }); 

            return Ok("Öne çıkan alanlar kısmı başarılı bir şekilde eklendi!");
        }

        

        [HttpPut]
        public IActionResult UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            //mapping kullanmadan 1. yöntem
            _sliderService.TUpdate(new Slider()
            {
                SliderId= updateSliderDto.SliderId,
                Title1 = updateSliderDto.Title1,
                Description1 = updateSliderDto.Description1,
                Title2 = updateSliderDto.Title2,
                Description2 = updateSliderDto.Description2,
                Title3 = updateSliderDto.Title3,
                Description3 = updateSliderDto.Description3
            });

            return Ok("Öne çıkan alanlar alanı güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSlider(int id)
        {
            var value= _sliderService.TGetById(id);

            _sliderService.TDelete(value);

            return Ok("Slider silindi");
        }
    }
}
