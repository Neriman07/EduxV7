using EduxV7.Data;
using System;
using System.Collections.Generic;

namespace EduxV7.Repo
{     // independence ignition yapabilmek için bu classı oluşturuyoruz
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Func<T, bool> where, params string[] nav);
        T Get(string id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
