using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities
{
    public class Testimonial
    {
        [Key]
        public int TestimonialId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string? Title { get; set; }

        [StringLength(1000)]
        public string? Comment { get; set; }

        [StringLength(1000)]
        public string? ImageUrl { get; set; }
        public bool? Status { get; set; }
    }
}
