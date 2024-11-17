using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Models
{
    public class Province
    {
        [Key]
        public int ProvinceID { get; set; }


        [StringLength(40)]
        [Required]
        public string ProvinceName { get; set; }

        //Navigation Property
        public ICollection<Address> Address { get; set; }
    }
}
