using Endorsed.Data.DBContext;
using Endorsed.Data.Repositories.HelperClasses;
using Endorsed.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Data.Repositories.DataRepository
{

   
    public class AddressRepository : IAddressHelper
    {
        private readonly IConfiguration _config;
        private readonly string _conString;


        private readonly EndorsedContextDb _context;


        public AddressRepository(IConfiguration configuration, EndorsedContextDb con)
        {
            _config = configuration;
            _conString = configuration.GetConnectionString("DefaultConnection");
            _context = con;
        }


        public Task<int> GetAddressID(Address address)
        {
            int t = _context.Addresses.Where(s => s.CityName == address.CityName && s.PostalCode == address.PostalCode && s.StreetName == address.StreetName).Select(r => r.AddressID).FirstOrDefault();

            return Task.FromResult(t);
        }


        public Task<int> Add(Address entity)
        {
            try
            {
                var res = _context.Addresses.Add(entity);

                return Task.FromResult(_context.SaveChanges());


            }
            catch (ExecutionEngineException e)
            {
                return Task.FromResult(00);
            }
        }
        

       public async Task<int> Delete(int ID)
        {
            try
            {
                var del = _context.Addresses.Find(ID);

                if (del == null)
                {
                    return await Task.FromResult(-1);
                }

                var res = _context.Addresses.Remove(del);
                _context.SaveChanges();
                return await Task.FromResult(1);
            }
            catch
            {
                return await Task.FromResult(0);
            }
        }


        public IEnumerable<Address> GetAll()
        {
           
            var res = _context.Addresses.ToList();
            return res;
                       
        }

        

    

        public Task<int> Update(Address entity)
        {
          
                var res = _context.Addresses.Update(entity);

            return Task.FromResult(_context.SaveChanges());
            
           
        }

        public ActionResult<Address>  GetBy(int ID)
        {
            var res = _context.Addresses.Find(ID);
            return res;
        }
    }
}
