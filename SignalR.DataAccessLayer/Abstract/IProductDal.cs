using SignalR.Api.DAL.Entities;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        /// <summary>
        /// ürünleri kategorileri ile birlikte getirir
        /// </summary>
        /// <returns></returns>
        List<Product> GetProductsWithCategories();

        /// <summary>
        /// ürünlerin sayısını getirir
        /// </summary>
        /// <returns></returns>
        int ProductCount();

        /// <summary>
        /// kategori adı  Hamburger olan ürünleri getirir
        /// </summary>
        /// <returns></returns>
        int ProductByCategoryNameHamburger();

        /// <summary>
        /// kategori adı  İçecek olan ürünleri getirir
        /// </summary>
        /// <returns></returns>
        int ProductByCategoryNameDrink();

        /// <summary>
        /// ürünlerin ortalama fiyatı
        /// </summary>
        /// <returns></returns>
        decimal ProductPriceAvg();


        /// <summary>
        /// en yüksek ürün fiyatına sahip ürün adını getirir
        /// </summary>
        /// <returns></returns>
        string ProductNameByMaxPrice();

        /// <summary>
        /// en düşük ürün fiyatlı adı
        /// </summary>
        /// <returns></returns>
        string ProductNameByMinPrice();

        /// <summary>
        /// ortalama hamburger fiyatı
        /// </summary>
        /// <returns></returns>
        decimal ProductAvgPriceByHamburger();


        decimal ProductPriceBySteakBurger();
    }
}
