using System.ComponentModel.DataAnnotations;

namespace SignalR.EntityLayer.Entities
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string? Description { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }
        public int PersonCount { get; set; }
        public DateTime? Date { get; set; }
    }
}
