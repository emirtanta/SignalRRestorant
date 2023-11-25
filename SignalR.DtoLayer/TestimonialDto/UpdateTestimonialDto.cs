using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.TestimonialDto
{
    public class UpdateTestimonialDto
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
