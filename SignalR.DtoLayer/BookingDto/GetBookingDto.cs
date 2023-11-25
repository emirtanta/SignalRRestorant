using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.BookingDto
{
    public class GetBookingDto
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
