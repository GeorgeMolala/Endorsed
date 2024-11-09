using Endorsed.Data.DBContext;
using Endorsed.Data.Repositories.HelperClasses;
using Endorsed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Data.Repositories.DataRepository
{
    public class AddressLinkRepository : IAddressLinkHelper
    {
        private readonly EndorsedContextDb _cont;

        public AddressLinkRepository(EndorsedContextDb context)
        {
            _cont = context;
        }

        public Task<int> Add(AddressLink entity)
        {
            var res = _cont.AddressLinks.Add(entity);
            return Task.FromResult(_cont.SaveChanges());
        }

        public Task<int> Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AddressLink> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(AddressLink entity)
        {
            throw new NotImplementedException();
        }
    }
}
