using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.MessageDto
{
	public class UpdateMessageDto
	{
		[Key]
		public int MessageId { get; set; }

		[StringLength(100)]
		public string NameSurname { get; set; }

		[StringLength(50)]
		public string Mail { get; set; }

		[StringLength(15)]
		public string PhoneNumber { get; set; }

		[StringLength(50)]
		public string Subject { get; set; }

		[StringLength(1000)]
		public string MessageContent { get; set; }
		public DateTime SendDate { get; set; }
		public bool Status { get; set; }
	}
}
