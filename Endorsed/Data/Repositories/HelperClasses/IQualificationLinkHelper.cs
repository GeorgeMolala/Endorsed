using Endorsed.Data.Repositories.DataRepository;
using Endorsed.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Data.Repositories.HelperClasses
{
    public interface IQualificationLinkHelper:IAppRepo<QualificationLink>
    {
        Task<int> AddQualificationLink(QualificationLink link);
        ActionResult<QualificationLink> GetBy(int ID);
    }
}
