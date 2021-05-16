using System.Collections.Generic;
using System.Threading.Tasks;
using WestCoastEducation.Models.StudentDtos;

namespace WestCoastEducation.Interfaces
{
    public interface IStudentRepository
    {
        void AddStudentToRepo(StudentDtoForCreation student);
        Task<IEnumerable<StudentDto>> GetAllStudentsAsync();
        Task<StudentDto> GetStudentByIdAsync(int id);
        void DeleteStudent(StudentDto student);
        void UpdateStudent(UpdateStudentDto student);
        Task<StudentDto> GetStudentByPersonalNumber(string personalnumber);
    } 
}
