using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WestCoastEducation.Entites;

namespace WestCoastEducation.Models.StudentDtos
{
    public class StudentDtoBaseClass
    {
        [Required(ErrorMessage = "Student firstname is missing"), MinLength(2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Student lastname is missing"), MinLength(2)]
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
