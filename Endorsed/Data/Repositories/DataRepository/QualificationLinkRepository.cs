using Endorsed.Data.DBContext;
using Endorsed.Data.Repositories.HelperClasses;
using Endorsed.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Data.Repositories.DataRepository
{
    public class QualificationLinkRepository:IQualificationLinkHelper
    {
        private readonly EndorsedContextDb _cont;

        public QualificationLinkRepository(EndorsedContextDb context)
        {
            _cont = context;
        }

        public async Task<int> Add(QualificationLink entity)
        {
            var res = _cont.QualificationLinks.Add(entity);

            return await Task.FromResult(_cont.SaveChanges());
        }

        public async Task<int> AddQualificationLink(QualificationLink link)
        {
            var res = _cont.QualificationLinks.AddAsync(link);
            return await Task.FromResult(_cont.SaveChanges());
        }

        public async Task<int> Delete(int ID)
        {
            var del = _cont.QualificationLinks.Find(ID);

            if(del == null)
            {
                return await Task.FromResult(-1);
            }

            var res = _cont.QualificationLinks.Remove(del);

            return await Task.FromResult(_cont.SaveChanges());
        }

        public IEnumerable<QualificationLink> GetAll()
        {
            var res = _cont.QualificationLinks.ToList();

            return res;
        }

        public async Task <int> Update(QualificationLink entity)
        {
            var res = _cont.QualificationLinks.Update(entity);

            return await Task.FromResult( _cont.SaveChanges());
        }

       

        public ActionResult<QualificationLink> GetBy(int ID)
        {
            var res = _cont.QualificationLinks.Find(ID);
            return res;
        }

        //Task<int> IAppRepo<QualificationLink>.Update(QualificationLink entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
