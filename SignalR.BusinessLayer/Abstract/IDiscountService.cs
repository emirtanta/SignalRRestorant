using SignalR.Api.DAL.Entities;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IDiscountService : IGenericService<Discount>
    {
		/// <summary>
		/// durumu aktife dönüştürür
		/// </summary>
		/// <param name="id"></param>
		void TChangeStatusToTrue(int id);

		/// <summary>
		/// durumu pasife dönüştürür
		/// </summary>
		/// <param name="id"></param>
		void TChangeStatusToFalse(int id);

		/// <summary>
		/// durumu aktif olanları liste olarak getirir
		/// </summary>
		/// <returns></returns>
		List<Discount> TGetListByStatusTrue();
	}
}
