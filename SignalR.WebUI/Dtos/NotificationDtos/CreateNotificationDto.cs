using System.ComponentModel.DataAnnotations;

namespace SignalR.WebUI.Dtos.NotificationDtos
{
    public class CreateNotificationDto
    {
        [Key]
        public int NotificationId { get; set; }

        [StringLength(50)]
        [Display(Name ="Bildirim Türü")]
        public string Type { get; set; }

        [Display(Name = "İkon")]
        [StringLength(50)]
        public string Icon { get; set; }

        [Display(Name = "Açıklama")]
        [StringLength(1000)]
        public string Description { get; set; }

        [Display(Name = "Durum")]
        public bool Status { get; set; }
    }
}
