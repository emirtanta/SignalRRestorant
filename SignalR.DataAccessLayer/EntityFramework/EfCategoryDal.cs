﻿using SignalR.Api.DAL.Entities;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(SignalRContext context) : base(context)
        {
        }

        public int ActiveCategoryCount()
        {
            using (var context=new SignalRContext())
            {
                return context.Categories.Where(x => x.Status == true).Count();
            }
        }

        /// <summary>
        /// kategorinin sayısını getirir
        /// </summary>
        /// <returns></returns>
        public int CategoryCount()
        {
            using (var context=new SignalRContext())
            {
                return context.Categories.Count();
            }
        }

        public int PasiveCategoryCount()
        {
            using (var context=new SignalRContext())
            {
                return context.Categories.Where(x => x.Status == false).Count();
            }
        }
    }
}
