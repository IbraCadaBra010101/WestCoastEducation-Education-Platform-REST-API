using AutoMapper;
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
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public StudentRepository(DataContext context, IMapper mapper)
        {
            _context = context; 
            _mapper = mapper;
        }
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
