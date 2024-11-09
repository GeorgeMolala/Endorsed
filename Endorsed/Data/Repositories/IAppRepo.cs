using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Data.Repositories
{
    public interface IAppRepo <T> where T:class
    {
        IEnumerable<T> GetAll();
        Task<int> Add(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(int ID);
      
    }
}
