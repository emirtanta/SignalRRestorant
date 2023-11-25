using SignalR.Api.DAL.Entities;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IDiscountDal : IGenericDal<Discount>
    {
        /// <summary>
        /// durumu aktife dönüştürür
        /// </summary>
        /// <param name="id"></param>
        void ChangeStatusToTrue(int id);

		/// <summary>
		/// durumu pasife dönüştürür
		/// </summary>
		/// <param name="id"></param>
		void ChangeStatusToFalse(int id);

        /// <summary>
        /// durumu aktif olanları liste olarak getirir
        /// </summary>
        /// <returns></returns>
        List<Discount> GetListByStatusTrue();
    }
}
