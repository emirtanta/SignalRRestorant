using System.ComponentModel.DataAnnotations;

namespace SignalR.WebUI.Dtos.AboutDtos
{
    public class ResultAboutDto
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
