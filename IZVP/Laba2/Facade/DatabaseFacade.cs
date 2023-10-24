using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba2.Facade
{
    internal class DatabaseFacade<T>
    {
        private IDatabase<T> database;

        public DatabaseFacade(IDatabase<T> database)
        {
            this.database = database;
        }

        public void Insert(T item)
        {
            database.Insert(item);
        }

        public void Update(T item)
        {
            database.Update(item);
        }

        public void Delete(T item)
        {
            database.Delete(item);
        }

        public T Get(int id)
        {
            return database.Get(id);
        }

        public List<T> GetAll()
        {
            return database.GetAll();
        }
    }
}
