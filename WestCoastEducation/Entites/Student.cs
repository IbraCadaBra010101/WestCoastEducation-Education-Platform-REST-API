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

        [Column(TypeName = "VARCHAR(20)")]
        public string FirstName { get; set; }


        [Column(TypeName = "VARCHAR(20)")]
        public string LastName { get; set; }

        [Column(TypeName = "VARCHAR(12)")]
        public string PersonalNumber { get; set; }


        [Column(TypeName = "VARCHAR(12)")]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "SMALLINT")]
        public int StreetNumber { get; set; }


        [Column(TypeName = "VARCHAR(12)")]
        public string City { get; set; }


        [Column(TypeName = "VARCHAR(12)")]
        public string PostalCode { get; set; }

        [Column(TypeName = "VARCHAR(20)")]
        public string Country { get; set; }


        public bool IsEnrolledInSchool { get; set; } // for when updating the student 


        [Column(TypeName = "SMALLINT")]
        public double AverageAttendance { get; set; } // for when updating the student


        public virtual ICollection<Course> Courses { get; set; } // for when updating the student
    }
}

