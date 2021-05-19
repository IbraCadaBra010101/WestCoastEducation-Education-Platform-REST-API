using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;
using WestCoastEducation.Entites;
using WestCoastEducation.Models.StudentDtos;

namespace WestCoastEducation.Interfaces
{
    public interface IStudentRepository
    {
        void AddStudentToRepo(StudentDtoForCreation student);
        Task<IEnumerable<StudentDto>> GetAllStudentsAsync();
        Task<StudentDto> GetStudentByPersonalNumber(string personalNumber);
        Task<Student> GetStudentByIdAsync(int id); 
        void DeleteStudent(Student student);
        void UpdateStudent(JsonPatchDocument<UpdateStudentDto> patchItem, Student course);
     }
}
