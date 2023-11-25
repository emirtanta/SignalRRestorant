using SignalR.Api.DAL.Entities;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int CategoryCount();

        /// <summary>
        /// aktif kategroi sayısını getirir
        /// </summary>
        /// <returns></returns>
        int ActiveCategoryCount();

        /// <summary>
        /// pasif kategroi sayınısı getirir
        /// </summary>
        /// <returns></returns>
        int PasiveCategoryCount();
    }
}
