using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Entites
{
    public class Student
    { 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public bool IsEnrolledInSchool { get; set; } // for when updating the student 
        public double AverageAttendance { get; set; } // for when updating the student
        public virtual ICollection<Course> Courses { get; set; } // for when updating the student
    }
}

