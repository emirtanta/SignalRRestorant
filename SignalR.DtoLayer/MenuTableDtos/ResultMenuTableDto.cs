using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.MenuTableDtos
{
	public class ResultMenuTableDto
	{
		[Key]
		public int MenuTableId { get; set; }

		[StringLength(50)]
		[Display(Name ="Masa Adı")]
		public string Name { get; set; }

		[Display(Name = "Masa Durumu")]
		public bool Status { get; set; }
	}
}
