using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
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
