using Endorsed.Data.DBContext;
using Endorsed.Data.Repositories.HelperClasses;
using Endorsed.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Data.Repositories.DataRepository
{
    public class QualificationRepository : IQualificationHelper
    {

        private readonly IConfiguration _config;
        private readonly string _conString;
        private EndorsedContextDb _cont;

        public QualificationRepository(IConfiguration configuration, EndorsedContextDb contextDb)
        {
            _config = configuration;
            _conString = configuration.GetConnectionString("DefaultConnection");
            _cont = contextDb;
        }

        public Task<int> Add(Qualification entity)
        {

            var res = _cont.Qualifications.Add(entity);

            _cont.SaveChanges();

            return Task.FromResult(1);
            
        }

        public Task<int> Delete(int ID)
        {
            var data = _cont.Qualifications.Find(ID);

            if(data != null)
            {
                _cont.Qualifications.Remove(data);

                _cont.SaveChanges();

                return Task.FromResult( _cont.SaveChanges());
               
            }


            return Task.FromResult(-1);
          
        }

        public IEnumerable<Qualification> GetAll()
        {
            var res = _cont.Qualifications.ToList();

            return res;
        }

        public ActionResult<Qualification> GetBy(int ID)
        {
            var res = _cont.Qualifications.Find(ID);

            return res;
        }

        public Task<int> Update(Qualification entity)
        {
            var res = _cont.Qualifications.Update(entity);
            
            return Task.FromResult(_cont.SaveChanges());
        }

       

        public Task<int> AddQualificationLink(QualificationLink link) //
        {
            throw new NotImplementedException();
        }

        public Task<int> GetQualificationID(Qualification entity)
        {
            var res = _cont.Qualifications.Where(s => s.QualififcationName == entity.QualififcationName && s.QualificationLevel == entity.QualificationLevel).Select(x => x.QualificationID).FirstOrDefault();
            return Task.FromResult(res);
        }

      

        Task<int> IQualificationHelper.GetQualificationID(Qualification entity)
        {
            throw new NotImplementedException();
        }

     
    }
}
