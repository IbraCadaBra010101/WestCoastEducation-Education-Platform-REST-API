
using System.ComponentModel.DataAnnotations;

namespace WestCoastEducation.Models.StudentDtos
{
    public class StudentDtoForCreation : StudentDtoBase
    {
        [Required(ErrorMessage = "Personalnumber is missing: 200012129999"), MaxLength(12), MinLength(12)]
        public string PersonalNumber { get; set; }
    }
}

