using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.NotificationDto
{
    public class ResultNotificationDto
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
