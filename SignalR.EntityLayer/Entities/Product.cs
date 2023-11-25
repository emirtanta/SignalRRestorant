using SignalR.EntityLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace SignalR.Api.DAL.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(1000)]
        public string? ImageUrl { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(1000)]
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public bool? ProductStatus { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //Product ile OrderDetail arasındaki 1'çok ilişki
        public List<OrderDetail> OrderDetails { get; set; }

        //Produtc ile Basket arasındaki 1'e çok ilişki
        public List<Basket> Baskets { get; set; }
        
    }
}
