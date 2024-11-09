using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Models.ViewModels
{
    public class PersonQualificationsViewModel
    {

        public ActionResult<Person> Person { get; set; }
        public IEnumerable<QualificationLink> QualificationLinks { get; set; }
    }
}
