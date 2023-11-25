using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.FeatureDto
{
    public class GetFeatureDto
    {
        [Key]
        public int FeatureId { get; set; }

        [StringLength(50)]
        [Display(Name = "Başlık 1")]
        public string Title1 { get; set; }

        [StringLength(1000)]
        [Display(Name = "Açıklama 1")]
        public string? Description1 { get; set; }

        [StringLength(50)]
        [Display(Name = "Başlık 2")]
        public string? Title2 { get; set; }

        [StringLength(1000)]
        [Display(Name = "Açıklama 2")]
        public string? Description2 { get; set; }

        [StringLength(50)]
        [Display(Name = "Başlık 3")]
        public string? Title3 { get; set; }

        [StringLength(1000)]
        [Display(Name = "Açıklama 3")]
        public string? Description3 { get; set; }
    }
}
