using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface INotificationDal : IGenericDal<Notification>
    {
        
        /// <summary>
        /// durumu okunmadı olanları getirir sayısını getirir
        /// </summary>
        /// <returns></returns>
        int NotificationCountByStatusFalse();

        /// <summary>
        /// durumu okunmadı olanların listesini  getirir
        /// </summary>
        /// <returns></returns>
        List<Notification> GetAllNotificationByFalse();


        /// <summary>
        /// bildirim durumunu okundu olarak değiştirir
        /// </summary>
        /// <param name="id"></param>
        void NotificationStatusChangeToTrue(int id);

        /// <summary>
        /// bildirim durumunu okunmadı olarak değiştirir
        /// </summary>
        /// <param name="id"></param>

        void NotificationStatusChangeToFalse(int id);
    }
}
