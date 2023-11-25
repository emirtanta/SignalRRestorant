using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly SignalRContext _context;

        public GenericRepository(SignalRContext context)
        {
            _context = context;
        }

        /// <summary>
        /// veritabanına data ekler
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Add(T entity)
        {
            _context.Add(entity);

            _context.SaveChanges();
        }


        /// <summary>
        /// veritabanına data siler
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Delete(T entity)
        {
            _context.Remove(entity);

            _context.SaveChanges();
        }


        /// <summary>
        /// id değerine göre veri getirir
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="NotImplementedException"></exception>
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        /// <summary>
        /// verileri liste halinde getirir
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="NotImplementedException"></exception>
        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }


        /// <summary>
        /// veritabanındaki datayı günceller
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Update(T entity)
        {
            _context.Update(entity);

            _context.SaveChanges();
        }
    }
}
