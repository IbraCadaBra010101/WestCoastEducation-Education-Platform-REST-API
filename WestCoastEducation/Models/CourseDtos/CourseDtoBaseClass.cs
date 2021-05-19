using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WestCoastEducation.Entites;

namespace WestCoastEducation.Models.CourseDtos
{
    public class CourseDtoBaseClass
    {
        public string CourseName { get; set; }
        public string CourseInformation { get; set; }
        public string Subject { get; set; }
        public string CourseActiveStatus { get; set; }

    }
}
