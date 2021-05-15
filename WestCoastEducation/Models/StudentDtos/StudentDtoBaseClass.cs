using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WestCoastEducation.Entites;

namespace WestCoastEducation.Models.StudentDtos
{
    public class StudentDtoBaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int StreetNumber { get; set; }
        public bool IsEnrolledInSchool { get; set; }
        public double AverageAttendance { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public virtual ICollection<Course> Courses { get; set; } // for when updating the student
    }
}
