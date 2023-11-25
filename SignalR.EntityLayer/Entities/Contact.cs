using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [StringLength(1000)]
        public string Location { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [StringLength(50)]
        public string? FooterTitle { get; set; }

        [StringLength(1000)]
        public string? FooterDescription { get; set; }

        [StringLength(50)]
        public string? OpenDays { get; set; }

        [StringLength(1000)]
        public string? OpenDaysDescription { get; set; }

        [StringLength(50)]
        public string? OpenOurs { get; set; }

        
    }
}
