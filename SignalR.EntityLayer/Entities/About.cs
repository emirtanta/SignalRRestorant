using System.ComponentModel.DataAnnotations;

namespace SignalR.EntityLayer.Entities
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }

        [StringLength(1000)]
        public string? ImageUrl { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(1000)]
        public string? Description { get; set; }
    }
}
