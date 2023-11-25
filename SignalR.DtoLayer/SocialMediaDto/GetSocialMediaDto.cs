using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.SocialMediaDto
{
    public class GetSocialMediaDto
    {
        [Key]
        public int SocialMediaId { get; set; }

        [StringLength(1000)]
        [Display(Name = "Resim")]
        public string? Icon { get; set; }

        [StringLength(50)]
        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [StringLength(1000)]
        [Display(Name = "Link")]
        public string? Url { get; set; }
    }
}
