using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        /// <summary>
        /// rezervasyonu onaylar
        /// </summary>
        void BookingStatusApproved(int id);

        /// <summary>
        /// rezervasyonu iptal eder
        /// </summary>
        /// <param name="id"></param>
        void BookingStatusCalcelled(int id);
    }
}
