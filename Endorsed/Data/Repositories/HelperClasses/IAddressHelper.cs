using Endorsed.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Data.Repositories.HelperClasses
{
    public interface IAddressHelper:IAppRepo<Address>
    {
        ActionResult<Address> GetBy(int ID);
        Task<int> GetAddressID(Address address);
    }
}
