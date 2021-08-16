using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public abstract class BaseRepository<T> where T :Base
    {
    
        public virtual void Create(T model)
        {
            using (var context = new ComContext())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
        }
        public virtual T Read(int id)
        {
            T model = Activator.CreateInstance<T>();
            using (var context = new ComContext())
            {
                model = context.Set<T>().Find(id);
            }
            return model;
        }
        public virtual List<T> Read()
        {
            List<T> list = new List<T>();
            using (var context = new ComContext())
            {
                list = context.Set<T>().ToList();
            }
            return list;
        }
        public virtual void Update(T model)
        {
            using (var context = new ComContext())
            {
                context.Entry<T>(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
        public virtual void Delete(int id)
        {
            using (var context = new ComContext())
            {
                context.Entry<T>(Read(id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
