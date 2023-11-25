using System.ComponentModel.DataAnnotations;

namespace SignalR.WebUI.Dtos.NotificationDtos
{
    public class UpdateNotificationDto
    {
        [Key]
        public int NotificationId { get; set; }

        [StringLength(50)]
        public string Type { get; set; }
        [StringLength(50)]
        public string Icon { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
