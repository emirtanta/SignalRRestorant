using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IOrderDal:IGenericDal<Order>
    {
        /// <summary>
        /// tüm siparişlerin sayısını getirir
        /// </summary>
        /// <returns></returns>
        int TotalOrderCount();

        /// <summary>
        /// aktif siparişlerin sayısını getirir
        /// </summary>
        /// <returns></returns>
        int ActiveOrderCount();

        /// <summary>
        /// son siparişi ve tutarını getirir
        /// </summary>
        /// <returns></returns>
        decimal LastOrderPrice();

        /// <summary>
        /// bugünkü toplam kazancı getirir
        /// </summary>
        /// <returns></returns>
        decimal TodayTotalPrice();
    }
}
