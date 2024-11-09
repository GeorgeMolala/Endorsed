using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Endorsed.Models
{
    public class Qualification
    {
        [Key]
        public int QualificationID { get; set; }

        [StringLength(25)]
        [Required]
        public string QualififcationName { get; set; }

        [StringLength(15)]
        [Required]
        public string QualificationLevel { get; set; }



        //Navigation Properties
        public ICollection<QualificationLink> QualificationLinks { get; set; }
    }
}
