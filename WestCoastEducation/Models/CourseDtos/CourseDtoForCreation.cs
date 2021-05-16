using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WestCoastEducation.Entites;

namespace WestCoastEducation.Models.CourseDtos
{
    public class CourseDtoForCreation : CourseDtoBaseClass
    {
        
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
