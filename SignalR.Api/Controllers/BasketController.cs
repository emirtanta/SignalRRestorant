using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.Api.Models;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.BasketDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet]
        public IActionResult GetBasketByMenuTableId(int id)
        {
            var values = _basketService.TGetBasketByMenuTableNumber(id);

            return Ok(values);
        }

        [HttpGet("BasketListByMenuTableWithProductName")]
        public IActionResult BasketListByMenuTableWithProductName(int id)
        {
            using (var context = new SignalRContext())
            {
                var values = context.Baskets.Include(x => x.Product)
                    .Where(y => y.MenuTableId == id)
                    .Select(z => new ResultBasketListWithProductsVM
                    {
                        BasketId=z.BasketId,
                        Count=z.Count,
                        MenuTableId=z.MenuTableId,
                        Price=z.Price,
                        TotalPrice=z.TotalPrice,
                        ProductId=z.ProductId,
                        ProductName=z.Product.ProductName
                    }).ToList();

                return Ok(values);
            }
        }

        [HttpGet]
        public IActionResult BasketList()
        {
            var values = _basketService.TGetListAll();

            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateBasketDto createBasketDto)
        {
            using (var context=new SignalRContext())
            {
                _basketService.TAdd(new Basket()
                {
                    ProductId = createBasketDto.ProductId,
                    Count = 1,
                    MenuTableId = 4,
                    Price = context.Products.Where(x => x.ProductId == createBasketDto.ProductId).Select(y => Convert.ToDecimal(y.Price)).FirstOrDefault(),
                    TotalPrice = 0
                    
                });

                return Ok();
            }
        }

        //[HttpGet("{id}")]
        //public IActionResult GetAbout(int id)
        //{
        //    var value= _aboutService.TGetById(id);

        //    return Ok(value);
        //}

        //[HttpPut]
        //public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
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

        [HttpDelete("{id}")]
        public IActionResult DeleteBasket(int id)
        {
            var value = _basketService.TGetById(id);

            _basketService.TDelete(value);

            return Ok($"{id} numaralı ürün kaldırıldı");
        }
    }
}
