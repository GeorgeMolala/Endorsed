using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        [Range(1,6)]
        [Required]
        public long HouseNumber { get; set; }

        [StringLength(50)]
        public string StreetName { get; set; }

        [StringLength(30)]
        [Required]
        public string SurburbName { get; set; }

        [StringLength(30)]
        [Required]
        public string CityName { get; set; }

        
        [Required]
        public int ProvinceID { get; set; }
       
        [Range(4,5)]
        [Required]
        public int PostalCode { get; set; }


        //Navigation Properties
        public ICollection<AddressLink> AddressLinks { get; set; }
        public Province Provinces { get; set; }
    }
}
