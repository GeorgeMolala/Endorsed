using Endorsed.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Data.Repositories.HelperClasses
{
    public interface IQualificationHelper:IAppRepo<Qualification>
    {
        ActionResult<Qualification> GetBy(int ID);
     
        Task<int> GetQualificationID(Qualification entity);
    }
}
