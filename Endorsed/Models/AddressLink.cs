using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Models
{
    public class AddressLink
    {

        [Key]
        public int AddressLinkID { get; set; }


        //Foreign Keys
        [Required]
        public int AddressID { get; set; }



        [Required]
        public int PersonID { get; set; }



        //Navigation Properties
        public Address Address { get; set; }
        public Person Person { get; set; }

    }
}
