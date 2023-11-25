using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IMoneyCaseService : IGenericService<MoneyCase>
    {
        /// <summary>
        /// toplam kasadaki tutarı getirir
        /// </summary>
        /// <returns></returns>
        decimal TTotalMoneyCaseAmount();
    }
}
