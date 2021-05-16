
using System.ComponentModel.DataAnnotations;

namespace WestCoastEducation.Models.StudentDtos
{
    public class StudentDtoForCreation : StudentDtoBaseClass
    {
        [Required( ErrorMessage = "The personal number is missing: format: xxxx-xx-xx-xxxx"), MinLength(14), MaxLength(14)]
        public string PersonalNumber { get; set; }


    }
}


// hur skapar man constraint för ett personnummer