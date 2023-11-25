using System.ComponentModel.DataAnnotations;

namespace SignalR.WebUI.Dtos.SocialMediaDtos
{
    public class ResultSocialMediaDto
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
