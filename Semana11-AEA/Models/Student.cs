using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Semana11_AEA.Models
{
    public class Student : Person
    {

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]

        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
 
    }
}