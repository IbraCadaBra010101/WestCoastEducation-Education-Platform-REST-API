using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WestCoastEducation.Entites;

namespace WestCoastEducation.Models.CourseDtos
{
    public class CourseDto : CourseDtoBaseClass
    {
        // View, but do not create or update
        public int Id { get; set; }
        // view but not updateable 
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
