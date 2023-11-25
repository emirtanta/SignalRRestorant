using System.ComponentModel.DataAnnotations;

namespace SignalR.WebUI.Dtos.MenuTableDtos
{
	public class ResultMenuTableDto
	{
		[Key]
		public int MenuTableId { get; set; }

		[StringLength(50)]
		[Display(Name = "Masa Adı")]
		public string Name { get; set; }

		[Display(Name = "Masa Durumu")]
		public bool Status { get; set; }
	}
}
