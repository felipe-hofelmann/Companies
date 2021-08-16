using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    class BaseRepository<T> where T :Base
    {
    
        public void Create(T model)
        {
            using (var context = new ComContext())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
        }
        public T Read(int id)
        {
            T model = Activator.CreateInstance<T>();
            using (var context = new ComContext())
            {
                model = context.Set<T>().Find(id);
            }
            return model;
        }
        public List<T> Read()
        {
            List<T> list = new List<T>();
            using (var context = new ComContext())
            {
                list = context.Set<T>().ToList();
            }
            return list;
        }
        public void Update(T model)
        {
            using (var context = new ComContext())
            {
                context.Entry<T>(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
        public void Delete(int id)
        {
            using (var context = new ComContext())
            {
                context.Entry<T>(Read(id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
