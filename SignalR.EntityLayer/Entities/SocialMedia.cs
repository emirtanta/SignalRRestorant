using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities
{
    public class SocialMedia
    {
        [Key]
        public int SocialMediaId { get; set; }

        [StringLength(1000)]
        public string? Icon { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(1000)]
        public string? Url { get; set; }
    }
}
