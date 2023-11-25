using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.MenuTableDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTableController : ControllerBase
    {
        private readonly IMenuTableService _menuTableService;

        public MenuTableController(IMenuTableService menuTableService)
        {
            _menuTableService = menuTableService;
        }

        [HttpGet]
        public IActionResult MenuTableList()
        {
            var values = _menuTableService.TGetListAll();

            return Ok(values);
        }



        [HttpPost]
        public IActionResult CreateMenuTable(CreateMenuTableDto createMenuTableDto)
        {
            //mapping kullanmadan 1. yöntem
            MenuTable menuTable = new MenuTable()
            {
                Name = createMenuTableDto.Name,
                Status = false
            };

            _menuTableService.TAdd(menuTable);

            return Ok("Masa başarılı bir şekilde eklendi!");
        }

        [HttpGet("{id}")]
        public IActionResult GetMenuTable(int id)
        {
            var value = _menuTableService.TGetById(id);

            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateMenuTable(UpdateMenuTableDto updateMenuTableDto)
        {
			//mapping kullanmadan 1. yöntem
			MenuTable about = new MenuTable()
            {
                MenuTableId = updateMenuTableDto.MenuTableId,
                Name = updateMenuTableDto.Name,
                Status = updateMenuTableDto.Status
            };
            _menuTableService.TUpdate(about);

            return Ok("Masa alanı güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMenuTable(int id)
        {
            var value = _menuTableService.TGetById(id);

            _menuTableService.TDelete(value);

            return Ok("Masa alanı silindi");
        }

        [HttpGet("MenuTableCount")]
        public IActionResult MenuTableCount()
        {
            var values = _menuTableService.TGetListAll();

            return Ok(values);
        }
    }
}
