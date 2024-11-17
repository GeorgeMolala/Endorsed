using Endorsed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Endorsed.Data.Repositories.HelperClasses;
using Microsoft.Extensions.Configuration;
using Endorsed.Data.DBContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Endorsed.Data.Repositories.DataRepository
{
    public class PersonRepository : IPersonHelper
    {
        private readonly IConfiguration _config;
        private readonly string _conString;
        private EndorsedContextDb _cont;

        public PersonRepository(IConfiguration configuration, EndorsedContextDb contextDb)
        {
            _config = configuration;
            _conString = configuration.GetConnectionString("DefaultConnection");
            _cont = contextDb;
        }

        public async Task<int> Add(Person entity)
        {
            var res =  _cont.People.AddAsync(entity);
            
            return await Task.FromResult(_cont.SaveChanges());
        }
        

        public Task<int> GetUserID(Person entity)
        {
            int t = _cont.People.Where(s => s.Email == entity.Email && s.Surname == entity.Surname && s.FirstName == entity.FirstName).Select(r => r.PersonID).FirstOrDefault();

            return Task.FromResult(t);
        }

        public async Task<int> Delete(int ID)
        {
            var del =  _cont.People.Find(ID);

            if(del != null)
            {
                var res = _cont.People.Remove(del);
                return await Task.FromResult(_cont.SaveChanges());
                
            }

            else
            {
                return await Task.FromResult(-1);
            }
        }

        public IEnumerable<Person> GetAll()
        {
            var res = _cont.People.ToList();
            return res;

        }
            
           

       public ActionResult<Person> GetBy(int ID)
        {
            var res = _cont.People
                .Include(p => p.AddressLinks)
                .Include(p => p.QualificationLinks)
                .FirstOrDefault(p => p.PersonID == ID);
            return  res;
        }

        public async Task<int> Update(Person entity)
        {
            var res =  _cont.People.Update(entity);

            return await _cont.SaveChangesAsync();
        }
    }
}
