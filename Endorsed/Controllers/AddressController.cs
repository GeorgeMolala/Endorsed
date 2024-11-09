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
    public class AddressController : Controller
    {

        private IAddressHelper _address;

        public AddressController(IAddressHelper address)
        {
            _address = address;
        }


        [HttpPost]
        public async Task<IActionResult> Add(Address data)
        {
            try
            {

                if (ModelState.IsValid)
                {
                   var res = await _address.Add(data);             
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
        public async Task<IActionResult> Update(Address address)
        {
            try
            {
                var res = await _address.Update(address);
                return Ok("Update Successfully");
            }
            catch
            {
                throw new ApplicationException("Something Went Wrong");
            }
           

            
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int ID)
        {

            try
            {
                var res = await _address.Delete(ID);

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

        [HttpGet]
        public IEnumerable<Address> GetAll()
        {
            try
            {
              
               var res =  _address.GetAll();             
               return res.ToList();
            
            }
            catch
            {
                throw new ApplicationException("Something went wrong" );
            }
           
        }

        [HttpGet]
        public ActionResult<Address> GetBy(int ID)
        {
            try
            {
                var res = _address.GetBy(ID);

                if (res.Value != null)
                {

                    return res;
                }
                else
                {
                    
                    return NotFound();
                }
                  
            }
            catch
            {
                throw new ApplicationException("Something Went Wrong");
            }
            
        }


    }
}
