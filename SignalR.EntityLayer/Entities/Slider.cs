using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities
{
    public class Slider
    {
        [Key]
        public int SliderId { get; set; }

        [StringLength(50)]
        public string? Title1 { get; set; }

        [StringLength(50)]
        public string? Title2 { get; set; }

        [StringLength(50)]
        public string? Title3 { get; set; }

        [StringLength(1000)]
        public string? Description1 { get; set; }

        [StringLength(1000)]
        public string? Description2 { get; set; }

        [StringLength(1000)]
        public string? Description3 { get; set; }
    }
}
