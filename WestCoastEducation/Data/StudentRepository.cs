using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WestCoastEducation.Interfaces;
using WestCoastEducation.Models.StudentDtos;

namespace WestCoastEducation.Data
{
    public class StudentRepository : IStudentRepository
    {
        public void AddStudentToRepo(StudentDtoForCreation student)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(StudentDto student)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StudentDto>> GetAllStudentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<StudentDto> GetStudentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(UpdateStudentDto student)
        {
            throw new NotImplementedException();
        }
    }
}
