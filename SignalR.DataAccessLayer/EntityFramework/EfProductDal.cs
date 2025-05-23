﻿using Microsoft.EntityFrameworkCore;
using SignalR.Api.DAL.Entities;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(SignalRContext context) : base(context)
        {

        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new SignalRContext();
            var values = context.Products.Include(x => x.Category)
                .ToList();

            return values;
        }

        public int ProductByCategoryNameDrink()
        {
            using (var context=new SignalRContext())
            {
                return context.Products.Where(x => x.CategoryId == (context.Categories.Where(y => y.CategoryName == "İçecek").Select(z => z.CategoryId).FirstOrDefault())).Count();
            }
        }

        public int ProductByCategoryNameHamburger()
        {
            using (var context = new SignalRContext())
            {
                return context.Products.Where(x => x.CategoryId == (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryId).FirstOrDefault())).Count();
            }
        }

        public int ProductCount()
        {
            using (var context = new SignalRContext())
            {
                return context.Products.Count();
            }
        }

        public string ProductNameByMaxPrice()
        {
            using (var context=new SignalRContext())
            {
                return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
            }
        }

        public string ProductNameByMinPrice()
        {
            using (var context = new SignalRContext())
            {
                return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
            }
        }

        public decimal ProductPriceAvg()
        {
            using (var context=new SignalRContext())
            {
                return context.Products.Average(x => (Convert.ToDecimal(x.Price)));
            }
        }

        public decimal ProductAvgPriceByHamburger()
        {
            using (var context=new SignalRContext())
            {
                return context.Products.Where(x => x.CategoryId == (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryId).FirstOrDefault())).Average(w => Convert.ToDecimal(w.Price));
            }
        }

        public decimal ProductPriceBySteakBurger()
        {
            using (var context=new SignalRContext())
            {
                return context.Products.Where(x => x.ProductName == "Steak Burger").Select(y => y.Price).Count();
            }
        }
    }
}
