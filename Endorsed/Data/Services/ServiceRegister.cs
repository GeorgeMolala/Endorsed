using Endorsed.Data.Repositories.DataRepository;
using Endorsed.Data.Repositories.HelperClasses;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Endorsed.Data.Services
{
    public static class ServiceRegister
    {
        public static void AddServices(this IServiceCollection service)
        {
            service.AddTransient<IPersonHelper, PersonRepository>();
            service.AddTransient<IAddressHelper, AddressRepository>();
            service.AddTransient<IQualificationHelper, QualificationRepository>();
            service.AddTransient<IAddressLinkHelper, AddressLinkRepository>();
            service.AddTransient<IQualificationLinkHelper, QualificationLinkRepository>();

        }

    }
}
