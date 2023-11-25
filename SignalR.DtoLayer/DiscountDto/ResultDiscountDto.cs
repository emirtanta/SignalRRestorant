using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.DiscountDto
{
    public class ResultDiscountDto
    {
        [Key]
        public int DiscountId { get; set; }

        [StringLength(50)]
        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [Display(Name = "Miktar")]
        public int? Amount { get; set; }

        [StringLength(1000)]
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }

        [StringLength(1000)]
        [Display(Name ="Resim")]
        public string? ImageIrl { get; set; }
		public bool? Status { get; set; }
	}
}
