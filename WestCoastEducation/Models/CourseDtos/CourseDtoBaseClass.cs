using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WestCoastEducation.Entites;

namespace WestCoastEducation.Models.CourseDtos
{
    public class CourseDtoBaseClass
    {
        public string CourseName { get; set; }
        public string CourseInformation { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string CourseActiveStatus { get; set; }
    }
}
