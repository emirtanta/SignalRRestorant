using System.ComponentModel.DataAnnotations;

namespace SignalR.WebUI.Dtos.FeatureDtos
{
    public class UpdateFeatureDto
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
