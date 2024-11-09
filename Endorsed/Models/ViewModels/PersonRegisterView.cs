using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Models.ViewModels
{
    [NotMapped]
    public class PersonRegisterView
    {
        [Key]
        public int PersonID { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }


        //Address Fields
        [Required]
        public long HouseNumber { get; set; }


        public string StreetName { get; set; }

        [Required]
        public string SurburbName { get; set; }

        [Required]
        public string CityName { get; set; }

        [Required]
        public int ProvinceID { get; set; }

        [Required]
        public int PostalCode { get; set; }
    }
}
