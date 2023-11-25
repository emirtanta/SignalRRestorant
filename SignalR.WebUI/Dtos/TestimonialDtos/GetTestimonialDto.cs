using System.ComponentModel.DataAnnotations;

namespace SignalR.WebUI.Dtos.TestimonialDtos
{
    public class GetTestimonialDto
    {
        [Key]
        public int TestimonialId { get; set; }

        [StringLength(50)]
        [Display(Name = "Ad-Soyad")]
        public string Name { get; set; }

        [StringLength(50)]
        [Display(Name = "Ünvan")]
        public string? Title { get; set; }

        [StringLength(1000)]
        [Display(Name = "Yorum")]
        public string? Comment { get; set; }

        [StringLength(1000)]
        [Display(Name = "Resim")]
        public string? ImageUrl { get; set; }

        [Display(Name = "Durum")]
        public bool? Status { get; set; }
    }
}
