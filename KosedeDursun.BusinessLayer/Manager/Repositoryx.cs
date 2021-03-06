using KosedeDursun.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KosedeDursun.BusinessLayer
{
    public class Repositoryx<T> where T:class
    {
        private DataAccessLayer.DataBaseContext db;
        private DbSet<T> _objectSet;

        public Repositoryx()
        {
            db = RepositoryBasex.CreateContext();
            _objectSet = db.Set<T>();
        }

        public List<T> List()
        {
            return _objectSet.ToList();
        }

        public List<T> List(Expression<Func<T,bool>> where)
        {
            return _objectSet.Where(where).ToList();
        }

        private int Save()
        {
            return db.SaveChanges();
        }

        public int Insert(T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }

        public int Update(T obj)
        {
            return Save();
        }

        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();
        }

        public T Find(Expression<Func<T,bool>> where)
        {
            return _objectSet.FirstOrDefault(where);
        }

        public List<T> OrderByLimitList<TKey>(Expression<Func<T, TKey>> orderby, bool isDesc, int adet, int altID){
            if(isDesc)
                return _objectSet.OrderByDescending(orderby).Skip(altID*adet).Take(adet).ToList();
            else
                return _objectSet.OrderBy(orderby).Skip(altID!=0?altID*adet:adet).Take(adet).ToList();
        }
    }
}
