using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.NotificationDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }


        [HttpGet]
        public IActionResult NotificationList()
        {
            var values = _notificationService.TGetListAll();

            return Ok(values);
        }



        [HttpPost]
        public IActionResult CreateNotification(CreateNotificationDto createNotificationDto)
        {
            //mapping kullanmadan 1. yöntem
            Notification about = new Notification()
            {
                Type = createNotificationDto.Type,
                Description = createNotificationDto.Description,
                Icon = createNotificationDto.Icon,
                Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                Status = false
            };

            _notificationService.TAdd(about);

            return Ok("Bidirim başarılı bir şekilde eklendi!");
        }

        [HttpGet("{id}")]
        public IActionResult GetNotification(int id)
        {
            var value = _notificationService.TGetById(id);

            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateNotification(UpdateNotificationDto updateNotificationDto)
        {
            //mapping kullanmadan 1. yöntem
            Notification notification = new Notification()
            {
                NotificationId = updateNotificationDto.NotificationId,
                Type = updateNotificationDto.Type,
                Description = updateNotificationDto.Description,
                Icon = updateNotificationDto.Icon,
                Date = updateNotificationDto.Date,
                Status = updateNotificationDto.Status
            };
            _notificationService.TUpdate(notification);

            return Ok($"{notification.NotificationId} numaralı Bildirim güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNotification(int id)
        {
            var value = _notificationService.TGetById(id);

            _notificationService.TDelete(value);

            return Ok($"{value.NotificationId} numaralı bildirim silindi");
        }

        //durumu okunmamış olan bildirim sayısını getirir
        [HttpGet("NotificationCountByStatusFalse")]
        public IActionResult NotificationCountByStatusFalse()
        {
            return Ok(_notificationService.TNotificationCountByStatusFalse());
        }

        //bildirimlerin durumu okunmamış olanların listesini getirir
        [HttpGet("GetAllNotificationByFalse")]
        public IActionResult GetAllNotificationByFalse()
        {
            return Ok(_notificationService.TGetAllNotificationByFalse());
        }


        [HttpGet("NotificationStatusChangeToFalse/{id}")]
        public IActionResult NotificationStatusChangeToFalse(int id)
        {
            _notificationService.TNotificationStatusChangeToFalse(id);

            return Ok("Güncelleme Yapıldı");
        }

        [HttpGet("NotificationStatusChangeToTrue/{id}")]
        public IActionResult NotificationStatusChangeToTrue(int id)
        {
            _notificationService.TNotificationStatusChangeToTrue(id);

            return Ok("Güncelleme Yapıldı");
        }
    }
}
