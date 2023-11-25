using System.ComponentModel.DataAnnotations;

namespace SignalR.Api.DAL.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }
        public bool? Status { get; set; }

        public List<Product> Products { get; set; }
    }
}
