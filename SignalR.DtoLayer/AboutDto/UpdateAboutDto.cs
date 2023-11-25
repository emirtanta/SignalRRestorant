using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.AboutDto
{
    public class UpdateAboutDto
    {
        [Key]
        public int AboutId { get; set; }

        [StringLength(1000)]
        [Display(Name = "Resim")]
        public string? ImageUrl { get; set; }

        [StringLength(50)]
        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [StringLength(1000)]
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }
    }
}
