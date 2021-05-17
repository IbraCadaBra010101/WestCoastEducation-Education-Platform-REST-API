using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WestCoastEducation.Entites;

namespace WestCoastEducation.Models.CourseDtos
{
    public class CourseDtoBaseClass
    {
       // [Required(ErrorMessage = "Kursnamn saknas!"), MaxLength(25)]
        public string CourseName { get; set; }


      //  [Required(ErrorMessage = "Kursbeskrivning saknas!"), MaxLength(200)]
        public string CourseInformation { get; set; }


       // [Required(ErrorMessage = "Kursämnet saknas!"), MaxLength(25, ErrorMessage = "Kursämnet överskrier max antal tecken")]
      
        public string Subject { get; set; }   
    }
}
