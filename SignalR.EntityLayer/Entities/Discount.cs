using System.ComponentModel.DataAnnotations;

namespace SignalR.Api.DAL.Entities
{
    public class Discount
    {
        [Key]
        public int DiscountId { get; set; }

        [StringLength(50)]
        public string Title { get; set; }
        public int? Amount { get; set; }

        [StringLength(1000)]
        public string? Description { get; set; }

        [StringLength(1000)]
        public string? ImageIrl { get; set; }
        public bool? Status { get; set; }
    }
}
