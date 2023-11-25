using System.ComponentModel.DataAnnotations;

namespace SignalR.WebUI.Dtos.ProductDtos
{
	public class CreateProductDto
	{

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

		[Display(Name = "Kategori Adı")]
		public int CategoryId { get; set; }
	}
}
