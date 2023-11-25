using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.Api.DAL.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.CategoryDto;
using SignalR.DtoLayer.ContactDto;
using SignalR.DtoLayer.DiscountDto;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());

            return Ok(values);
        }

        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var context = new SignalRContext();
            var values = context.Products.Include(x => x.Category).Select(y => new ResultProdcutWithCategoryDto
            {
                ProductId = y.ProductId,
                ProductName = y.ProductName,
                CategoryName = y.Category.CategoryName,
                Description = y.Description,
                ImageUrl = y.ImageUrl,
                Price = y.Price,
                ProductStatus = y.ProductStatus
            }).ToList();

            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetById(id);

            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
                ProductName = createProductDto.ProductName,
                Description = createProductDto.Description,
                ImageUrl = createProductDto.ImageUrl,
                Price = createProductDto.Price,
                ProductStatus = true,
                CategoryId = createProductDto.CategoryId
            });

            return Ok("Ürün kısmı başarılı bir şekilde eklendi!");
        }



        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            //mapping kullanmadan 1. yöntem
            _productService.TAdd(new Product()
            {
                ProductId = updateProductDto.ProductId,
                ProductName = updateProductDto.ProductName,
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,
                Price = updateProductDto.Price,
                ProductStatus = updateProductDto.ProductStatus,
                CategoryId = updateProductDto.CategoryId
            });

            return Ok("Ürün alanı güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);

            _productService.TDelete(value);

            return Ok("Ürün alanı silindi");
        }

        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            var values = _productService.TProductCount();

            return Ok(values);
        }

        [HttpGet("ProductCountByHamburger")]
        public IActionResult ProductCountByHamburger()
        {
            var values = _productService.TProductByCategoryNameHamburger();

            return Ok(values);
        }

        [HttpGet("ProductCountByDrink")]
        public IActionResult ProductCountByDrink()
        {
            var values = _productService.TProductByCategoryNameDrink();

            return Ok(values);
        }

        [HttpGet("ProductPriceAvg")]
        public IActionResult ProductPriceAvg()
        {
            var values = _productService.TProductPriceAvg();

            return Ok(values);
        }

        [HttpGet("ProductNameByMaxPrice")]
        public IActionResult ProductNameByMaxPrice()
        {
            var values = _productService.TProductNameByMaxPrice();

            return Ok(values);
        }

        [HttpGet("ProductNameByMinPrice")]
        public IActionResult ProductNameByMinPrice()
        {
            var values = _productService.TProductNameByMinPrice();

            return Ok(values);
        }


        [HttpGet("ProductAvgPriceByHamburger")]
        public IActionResult ProductAvgPriceByHamburger()
        {
            var values = _productService.TProductAvgPriceByHamburger();

            return Ok(values);
        }

        [HttpGet("ProductPriceBySteakBurger")]
        public IActionResult ProductPriceBySteakBurger()
        {
            var values = _productService.TProductPriceBySteakBurger();

            return Ok(values);
        }
    }
}
