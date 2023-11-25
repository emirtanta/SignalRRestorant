using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.Api.DAL.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService,IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());

            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            
            return Ok(value);
        }


        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryService.TAdd(new Category() 
            {
                CategoryName=createCategoryDto.CategoryName,
                Status=true
            }); 

            return Ok("Kategori kısmı başarılı bir şekilde eklendi!");
        }

        

        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
			//mapping kullanmadan 1. yöntem
			_categoryService.TUpdate(new Category()
			{
				CategoryName = updateCategoryDto.CategoryName,
				CategoryId = updateCategoryDto.CategoryId,
				Status = updateCategoryDto.Status
			});

			return Ok("Kategori alanı güncellendi");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var value=_categoryService.TGetById(id);

            _categoryService.TDelete(value);

            return Ok("Kategori alanı silindi");
        }

        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            var value = _categoryService.TCategoryCount();

            return Ok(value);
        }

        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            var value = _categoryService.TActiveCategoryCount();

            return Ok(value);
        }

        [HttpGet("PasiveCategoryCount")]
        public IActionResult PasiveCategoryCount()
        {
            var value = _categoryService.TPasiveCategoryCount();

            return Ok(value);
        }
    }
}
