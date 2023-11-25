using SignalR.Api.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities
{
    public class Basket
    {
        [Key]
        public int BasketId { get; set; }
        
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }

        //Basket ile Masa arasındaki ilişki
        public int MenuTableId { get; set; }
        public MenuTable MenuTable { get; set; }

        //Basket ile Ürün arasındaki 1'e çok ilişki
        public int ProductId { get; set; }
        public Product  Product { get; set; }
    }
}
