using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Models
{
    public class QualificationLink
    {
        [Key]
        public int QualificationLinkID { get; set; }

        public string QualificationDescription { get; set; }

        //Foreign Keys
        [Required]
        public int PersonID { get; set; }

        [Required]
        public int QualificationID { get; set; }


        //Navigation Properties
        public Person Person { get; set; }
        public Qualification Qualification { get; set; }

    }
}
