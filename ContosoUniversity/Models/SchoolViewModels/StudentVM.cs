﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ContosoUniversity.Models.SchoolViewModels
{
    public class StudentVM : IValidatableObject
    {
        [Display(Name = "Last Name :")]
        public string LastName { get; set; }

        [Display(Name = "First Name :")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date From :")]
        public DateTime? EnrollmentDateFrom { get; set; } // ? (NULLABLE)

        [DataType(DataType.Date)]
        [Display(Name = "Until :")]
        public DateTime? EnrollmentDateUntil { get; set; } // ? (NULLABLE)

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (FirstMidName == null)
            {
                yield return new ValidationResult("input first name!", new[] { "FirstMidName" });
                //Memberi validation jika sebuah kolom pencarian tidak diisi!
            }
            
            if (LastName == null)
            {
                yield return new ValidationResult("input last name!", new[] { "LastName" });
                //Memberi validation jika sebuah kolom pencarian tidak diisi!
            }

            if (EnrollmentDateFrom == null)
            {
                yield return new ValidationResult("input date from!", new[] { "EnrollmentDateFrom" });
                //Memberi validation ke variable yang dituju!
            }
            if (EnrollmentDateUntil == null)
            {
                yield return new ValidationResult("input date until!", new[] { "EnrollmentDateUntil" });
                //Memberi validation ke variable yang dituju!
            }
        }
    }

}
