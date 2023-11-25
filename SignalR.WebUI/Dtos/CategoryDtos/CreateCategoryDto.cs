using System.ComponentModel.DataAnnotations;

namespace SignalR.WebUI.Dtos.CategoryDtos
{
	public class CreateCategoryDto
	{

		[StringLength(50)]
		[Display(Name = "Kategori Adı")]
		public string CategoryName { get; set; }

		[Display(Name = "Durum")]
		public bool? Status { get; set; }
	}
}
