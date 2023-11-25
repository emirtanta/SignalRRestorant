using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;

namespace SignalR.WebUI.Controllers
{
	public class QRCodeController : Controller
	{

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(string value)
		{
			#region QR Code oluşturma bölümü

			using (MemoryStream memoryStream = new MemoryStream())
			{
				QRCodeGenerator createQRCode = new QRCodeGenerator();
				QRCodeGenerator.QRCode squareCode = createQRCode.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);

				//çizimler için tnaımlandı
				using (Bitmap image=squareCode.GetGraphic(10))
				{
					image.Save(memoryStream, ImageFormat.Png);

					ViewBag.QrCodeImage = "data:image/png;base64," + Convert.ToBase64String(memoryStream.ToArray());
				}
			}

			#endregion


			return View();
		}
	}
}
