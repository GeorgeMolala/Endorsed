using Endorsed.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Data.DBContext
{
    public class EndorsedContextDb:DbContext
    {

        public EndorsedContextDb(DbContextOptions<EndorsedContextDb> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressLink> AddressLinks { get; set; }
        public DbSet<Person> People { get; set; }

        public DbSet<Qualification> Qualifications { get; set; }

        public DbSet<QualificationLink> QualificationLinks { get; set; }

        public DbSet<Province> Provinces { get; set; }
    }
}
