using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WestCoastEducation.Entites;

namespace WestCoastEducation.Models.CourseDtos
{
    public class UpdateCourseDto : CourseDtoBaseClass
    {
        [Range(0,100)]
        public double AverageAttendance { get; set; }

        [Range(0, 5)]
        public double AverageGrade { get; set; }

        public bool IsCanceled { get; set; }
    } 
}
