using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IOrderService:IGenericService<Order>
    {
        /// <summary>
        /// tüm siparişlerin sayısını getirir
        /// </summary>
        /// <returns></returns>
        int TTotalOrderCount();

        /// <summary>
        /// aktif siparişlerin sayısını getirir
        /// </summary>
        /// <returns></returns>
        int TActiveOrderCount();

        /// <summary>
        /// son siparişi ve tutarını getirir
        /// </summary>
        /// <returns></returns>
        decimal TLastOrderPrice();

        /// <summary>
        /// bugünkü toplam kazancı getirir
        /// </summary>
        /// <returns></returns>
        decimal TTodayTotalPrice();
    }
}
