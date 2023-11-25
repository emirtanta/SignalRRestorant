using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.ProductDto
{
    public class GetProductDto
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(1000)]
        [Display(Name = "Ürün Resmi")]
        public string? ImageUrl { get; set; }

        [StringLength(50)]
        [Display(Name = "Ürün Adı")]
        public string ProductName { get; set; }

        [StringLength(1000)]
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }

        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }

        [Display(Name = "Durum")]
        public bool? ProductStatus { get; set; }
		public int CategoryId { get; set; }
	}
}
