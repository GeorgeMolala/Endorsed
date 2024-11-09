using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Endorsed.Data.Repositories.HelperClasses;
using Endorsed.Models.ViewModels;
using Endorsed.Models;

namespace Endorsed.Controllers
{

    [Route ("api/[controller]/[action]")]
    [ApiController]
    public class PersonController : Controller
    {
        private  IPersonHelper _person;
        private IAddressHelper _address;
        private IAddressLinkHelper _linkaddress;
        private  int Temp;

        public PersonController(IPersonHelper person, IAddressHelper address, IAddressLinkHelper linkHelper)
        {
            _person = person;
            _address = address;
            _linkaddress = linkHelper;
        }


        [HttpPost]
        public async Task<ActionResult> AddPerson(PersonRegisterView registerView)
        {
            //int UserID;
            //int LocationID;


            if (ModelState.IsValid)
            {
               var pers = new Person
               {
                            FirstName = registerView.FirstName,
                            MiddleName = registerView.MiddleName,
                            Surname = registerView.Surname,
                            Age = registerView.Age,
                            Email = registerView.Email
                };

                var adr = new Address
                {           
                            HouseNumber = registerView.HouseNumber,
                            StreetName = registerView.StreetName,
                            SurburbName = registerView.SurburbName,
                            CityName = registerView.CityName,
                            ProvinceID = registerView.ProvinceID,
                            PostalCode = registerView.PostalCode
                };

                try
                {

                    //Registering Person
                    var Pres = await _person.Add(pers);

                    if (Pres > 0)
                    {
                        int temp = await _person.GetUserID(pers);



                        //Populating Address Link Table using UserID just added
                        var res =  _address.Add(adr);
                        int LocationID = await _address.GetAddressID(adr);
                        var linkAd = new AddressLink
                        {
                            AddressID = LocationID,
                            PersonID = temp
                        };

                        var ress = _linkaddress.Add(linkAd);

                        return Ok("Successfully Added");

                    }
                    else
                    {
                        return StatusCode(500);
                    }
                }
                catch
                {
                    throw new ApplicationException("Something Went Wrong");
                }
               
            }

            return StatusCode(400);
         
        }

        
        [HttpPost]
        public async Task<ActionResult> AddPersonAddress(AddressLink adrs)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    var res = await _linkaddress.Add(adrs);                 
                    return Ok("Successfully Added");
                }

                return StatusCode(400);

            }
            catch
            {
                throw new ApplicationException("Something Went Wrong");
            }
        }

        [HttpDelete]
        public async Task<ActionResult> DeletePerson(int ID)
        {
            try
            {
                var res = await _person.Delete(ID);

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
                throw new ApplicationException("Something Went Wrong");
            }
        }


        [HttpPut]
        public async Task<ActionResult> UpdatePerson(Person person)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var res = await _person.Update(person);
                    
                    return Ok("Updated Successfully");
                }

                return StatusCode(400);
            }
            catch
            {
                throw new ApplicationException("Something Went wrong");
            }
        }


        [HttpGet]
        public  ActionResult GetBy(int ID)
        {
            try
            {
                
              //  Person person = new Person();

                var res = _person.GetBy(ID);


                //var res = new PersonQualificationsViewModel
                //{                                        
                //    Person = _person.GetBy(ID),
                //    QualificationLinks = _person.GetAll()

                //};

                return Ok(res);
            }
            catch
            {
                throw new ApplicationException("Something went wrong");
            }
        }
       
    }
}
