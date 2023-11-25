using SignalR.Api.DAL.Entities;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        /// <summary>
        /// ürünleri kategorileri ile beraber getirir
        /// </summary>
        /// <returns></returns>
        List<Product> TGetProductsWithCategories();

        /// <summary>
        /// ürünlerin sayısını getirir
        /// </summary>
        /// <returns></returns>
        int TProductCount();

        /// <summary>
        /// kategori adı  Hamburger olan ürünleri getirir
        /// </summary>
        /// <returns></returns>
        int TProductByCategoryNameHamburger();

        /// <summary>
        /// kategori adı  İçecek olan ürünleri getirir
        /// </summary>
        /// <returns></returns>
        int TProductByCategoryNameDrink();

        /// <summary>
        /// ürünlerin ortalama fiyatı
        /// </summary>
        /// <returns></returns>
        decimal TProductPriceAvg();

        /// <summary>
        /// en yüksek ürün fiyatına sahip ürün adını getirir
        /// </summary>
        /// <returns></returns>
        string TProductNameByMaxPrice();

        /// <summary>
        /// en düşük ürün fiyatlı adı
        /// </summary>
        /// <returns></returns>
        string TProductNameByMinPrice();

        /// <summary>
        /// ortalama hamburger fiyatı
        /// </summary>
        /// <returns></returns>
        decimal TProductAvgPriceByHamburger();

        decimal TProductPriceBySteakBurger();
    }
}
