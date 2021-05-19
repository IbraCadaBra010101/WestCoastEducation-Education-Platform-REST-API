using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Required(ErrorMessage = "Personalnumber is missing: 200012129999"), MaxLength(12), MinLength(12)]
        public string PersonalNumber { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Required(ErrorMessage = "Missing course status. Write if course is  cancele or active")]
        public string CourseActiveStatus { get; set; }

        [Column(TypeName = "VARCHAR(20)")]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "SMALLINT")]
        public int StreetNumber { get; set; }


        [Column(TypeName = "VARCHAR(12)")]
        public string City { get; set; }

        [Column(TypeName = "VARCHAR(12)")]
        public string StreetName { get; set; }


        [Column(TypeName = "VARCHAR(12)")]
        public string PostalCode { get; set; }


        [Column(TypeName = "VARCHAR(60)")]
        public string Country { get; set; }

    }
}

