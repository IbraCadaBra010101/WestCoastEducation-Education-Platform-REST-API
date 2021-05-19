using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Models.StudentDtos
{
    public class UpdateStudentDto
    {
        public string PhoneNumber { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
 