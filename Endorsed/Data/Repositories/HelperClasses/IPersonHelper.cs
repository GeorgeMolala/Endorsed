using Endorsed.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Data.Repositories.HelperClasses
{
    public interface IPersonHelper:IAppRepo<Person>
    {

        ActionResult<Person> GetBy(int ID);
        Task<int> GetUserID(Person entity);

    }
}
