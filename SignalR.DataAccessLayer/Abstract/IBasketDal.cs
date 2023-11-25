using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IBasketDal:IGenericDal<Basket>
    {

        /// <summary>
        /// aktif masa numarasındaki ürünleri getirir;
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Basket> GetBasketByMenuTableNumber(int id);
    }
}
