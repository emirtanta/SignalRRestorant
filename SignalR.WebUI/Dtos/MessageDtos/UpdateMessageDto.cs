using System.ComponentModel.DataAnnotations;

namespace SignalR.WebUI.Dtos.MessageDtos
{
	public class UpdateMessageDto
	{
		public int MessageId { get; set; }

		[StringLength(100)]
		[Display(Name = "Ad Soyad")]
		public string NameSurname { get; set; }

		[StringLength(50)]
		[Display(Name = "Mail")]
		public string Mail { get; set; }

		[StringLength(15)]
		[Display(Name = "Telefon")]
		public string PhoneNumber { get; set; }

		[StringLength(50)]
		[Display(Name = "Konu")]
		public string Subject { get; set; }

		[StringLength(1000)]
		[Display(Name = "Açıklama")]
		public string MessageContent { get; set; }

		[Display(Name = "Gönderilme Tarihi")]
		public DateTime SendDate { get; set; }

		[Display(Name = "Durum")]
		public bool Status { get; set; }
	}
}
