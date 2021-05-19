using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WestCoastEducation.Entites
{
    [Table("Course", Schema = "Courses")]
    public class Course
    {
        public int Id { get; set; }


        [Column(TypeName = "VARCHAR(25)")]
        public string CourseName { get; set; }


        [Column(TypeName = "VARCHAR(200)")]
        public string CourseInformation { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        public string Subject { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Required(ErrorMessage = "Missing course status. Write if course is  cancele or active")]
        public string CourseActiveStatus { get; set; }

        public DateTime? StartDate { get; set; }


        public DateTime? FinishDate { get; set; }
    }
}
