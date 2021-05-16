using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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

        public DateTime? StartDate { get; set; }


        public DateTime? FinishDate { get; set; }
    }
}
