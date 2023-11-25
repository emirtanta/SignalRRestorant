using System.ComponentModel.DataAnnotations;

namespace SignalR.WebUI.Dtos.DiscountDtos
{
    public class UpdateDiscountDto
    {
        [Key]
        public int DiscountId { get; set; }

        [StringLength(50)]
        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [Display(Name = "Miktar")]
        public int? Amount { get; set; }

        [StringLength(1000)]
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }

        [StringLength(1000)]
        [Display(Name = "Resim")]
        public string? ImageIrl { get; set; }
		public bool? Status { get; set; }
	}
}
