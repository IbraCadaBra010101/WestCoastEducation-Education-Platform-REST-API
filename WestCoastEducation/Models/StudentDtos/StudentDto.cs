

using System;

namespace WestCoastEducation.Models.StudentDtos
{
    public class StudentDto : StudentDtoBase
    {
        public int Id { get; set; }
        public string PersonalNumber { get; set; }
    }
}
