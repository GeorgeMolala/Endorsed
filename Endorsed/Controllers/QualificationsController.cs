using Endorsed.Data.Repositories.HelperClasses;
using Endorsed.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Controllers
{

    [Route ("api/[controller]/[action]")]
    [ApiController]
    public class QualificationsController : Controller
    {

        private readonly IQualificationHelper qualification;
        private readonly IQualificationLinkHelper _linkHelper;

        public QualificationsController(IQualificationHelper helper, IQualificationLinkHelper linkhelper)
        {
            qualification = helper;
            _linkHelper = linkhelper;

        }

        
        //Managing Qualifications

        [HttpGet]
        public ActionResult<Qualification> Getby(int ID)
        {
            try
            {
                var res =  qualification.GetBy(ID);

                if(res.Value == null)
                {
                    return NotFound();
                }

                return res;
            }
            catch
            {
                throw new ApplicationException("Something Went Wrong");
            }

        }


        [HttpGet]
        public IEnumerable<Qualification> GetAll()
        {
            try
            {
                var res = qualification.GetAll().ToList();               
                return res;                                           
            }
            catch
            {
                throw new ApplicationException("Something Went Wrong");
            }
        }


        [HttpPost]
        public async Task<ActionResult> Add(Qualification qual)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   var res = await qualification.Add(qual);
                 //  TempData["QualiID"] = await qualification.GetQualificationID(qual);

                   return Ok("Added Successfully");
                }

                return StatusCode(400);
            }
            catch
            {
                throw new ApplicationException("Something Went Wrong");
            }
        }


        [HttpPut]
        public async Task<ActionResult> Update(Qualification qual)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var res = await qualification.Update(qual);
                    return Ok("Updated Successfully");
                }

                return StatusCode(400);
            }
            catch
            {
                throw new ApplicationException("Something Went Wrong");
            }
        }


        [HttpDelete]
        public async Task<ActionResult> Delete(int ID)
        {
            try
            {
                var res = await qualification.Delete(ID);
                
                if(res == -1)
                {
                    return NotFound();                
                }

                return Ok("Deleted Successfully");
                
                
            }
            catch
            {
                throw new ApplicationException("Something Went Wrong");
            }
        }




        //Managing Persons Qualifications

        [HttpPost]
        public async Task<ActionResult> AddPersonQualification(QualificationLink link)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var res =await _linkHelper.AddQualificationLink(link);

                    return Ok("Added Successfully");
                }
                else
                {
                    return StatusCode(400);
                }
            }
            catch
            {
                throw new ApplicationException("Something Went Wrong");
            }
        } 

        [HttpPut]
        public async Task<ActionResult> UpdatePersonQualification(QualificationLink qual)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   var res = await _linkHelper.Update(qual);
                   return Ok("Updated Successfully");
                }

                return StatusCode(400);
            }
            catch
            {
                throw new ApplicationException("Something Went wrong");
            }
        }


        [HttpDelete]
        public async Task<ActionResult> DeletePersonQualification(int ID)
        {
            try
            {
                var res = await _linkHelper.Delete(ID);
                
                if(res == -1)
                {
                    return NotFound();
                }
                else
                {
                    return Ok("Deleted Successfully");
                }
                
            }
            catch
            {
                throw new ApplicationException("Somethng Went wrong");
            }
        }


        [HttpGet]
        public ActionResult<QualificationLink> GetByPersonQualification(int ID)
        {
            try
            {
                var res =  _linkHelper.GetBy(ID);

                if (res.Value !=null)
                {
                    return Ok(res);
                }

                return NotFound();
            }
            catch
            {
                throw new ApplicationException("Something went wrong");
            }
        }

        [HttpGet]
        public  IEnumerable<QualificationLink> GetAllPersonQualification()
        {
            try
            {
                var res =  _linkHelper.GetAll().ToList();
                
                return res;
                             
            }
            catch
            {
                throw new ApplicationException("Something went wrong");
            }
        }
    }
}
