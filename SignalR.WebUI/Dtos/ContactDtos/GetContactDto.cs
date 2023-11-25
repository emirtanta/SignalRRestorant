using System.ComponentModel.DataAnnotations;

namespace SignalR.WebUI.Dtos.ContactDtos
{
    public class GetContactDto
    {
        [Key]
        public int ContactId { get; set; }

        [StringLength(1000)]
        [Display(Name = "Lokasyon")]
        public string Location { get; set; }

        [StringLength(50)]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [StringLength(50)]
        [Display(Name = "Mail")]
        public string Mail { get; set; }

        [StringLength(50)]
        [Display(Name = "Başlık")]
        public string? FooterTitle { get; set; }

        [StringLength(1000)]
        [Display(Name = "Açıklama")]
        public string? FooterDescription { get; set; }

        [StringLength(50)]
        [Display(Name = "Açık Günler")]
        public string? OpenDays { get; set; }

        [StringLength(1000)]
        [Display(Name = "Açık Olan Günler Açıklama")]
        public string? OpenDaysDescription { get; set; }

        [StringLength(50)]
        [Display(Name = "Açık Saatler")]
        public string? OpenOurs { get; set; }
    }
}
