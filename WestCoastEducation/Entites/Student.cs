using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Entites
{  
    [Table("Student", Schema = "Students")]
    public class Student
    { 
      
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(14)")]
        public string FirstName { get; set; }

        [Column(TypeName = "VARCHAR(14)")]
        public string LastName { get; set; }
      
        [Column(TypeName = "CHAR(14)")]
        public string PersonalNumber { get; set; }

        [Column(TypeName = "VARCHAR(20)")]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "SMALLINT")]
        public int StreetNumber { get; set; }


        [Column(TypeName = "VARCHAR(12)")]
        public string City { get; set; }


        [Column(TypeName = "VARCHAR(12)")]
        public string PostalCode { get; set; }


        [Column(TypeName = "VARCHAR(60)")]
        public string Country { get; set; }


     }
}

