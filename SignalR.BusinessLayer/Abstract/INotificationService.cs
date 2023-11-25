using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface INotificationService : IGenericService<Notification>
    {
        /// <summary>
        /// durumu okunmadı olanları getirir sayısını getirir
        /// </summary>
        /// <returns></returns>
        int TNotificationCountByStatusFalse();

        /// <summary>
        /// durumu okunmadı olanların listesini  getirir
        /// </summary>
        /// <returns></returns>
        List<Notification> TGetAllNotificationByFalse();

        /// <summary>
        /// bildirim durumunu okundu olarak değiştirir
        /// </summary>
        /// <param name="id"></param>
        void TNotificationStatusChangeToTrue(int id);

        /// <summary>
        /// bildirim durumunu okunmadı olarak değiştirir
        /// </summary>
        /// <param name="id"></param>

        void TNotificationStatusChangeToFalse(int id);
    }
}
