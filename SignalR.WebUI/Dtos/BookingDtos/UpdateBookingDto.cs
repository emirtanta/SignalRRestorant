using System.ComponentModel.DataAnnotations;

namespace SignalR.WebUI.Dtos.BookingDtos
{
    public class UpdateBookingDto
    {
        [Key]
        public int BookingId { get; set; }

        [StringLength(50)]
        [Display(Name = "Ad")]
        public string Name { get; set; }

        [StringLength(1000)]
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }

        [StringLength(50)]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [StringLength(50)]
        [Display(Name = "Mail")]
        public string Mail { get; set; }

        [Display(Name = "Personel Sayısı")]
        public int PersonCount { get; set; }

        [Display(Name = "Tarih")]
        public DateTime? Date { get; set; }
    }
}
