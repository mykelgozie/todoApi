using serviceslibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceslibrary
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public Task Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Find(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task Save(T t)
        {
            throw new NotImplementedException();
        }

        public Task Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
