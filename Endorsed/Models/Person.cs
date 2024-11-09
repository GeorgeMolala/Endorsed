using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        [StringLength(20)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(40)]
        public string MiddleName { get; set; }

        [StringLength(20)]
        [Required]
        public string Surname { get; set; }

        [Range(16,120)]
        [Required]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }



        //Navigation Property
        public ICollection<QualificationLink> QualificationLinks { get; set; }
        public ICollection<AddressLink> AddressLinks { get; set; }

        
    }
}
