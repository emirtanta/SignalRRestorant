using SignalR.Api.DAL.Entities;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        public int TCategoryCount();

        /// <summary>
        /// aktif kategroi sayısını getirir
        /// </summary>
        /// <returns></returns>
        int TActiveCategoryCount();

        /// <summary>
        /// pasif kategroi sayınısı getirir
        /// </summary>
        /// <returns></returns>
        int TPasiveCategoryCount();
    }
}
