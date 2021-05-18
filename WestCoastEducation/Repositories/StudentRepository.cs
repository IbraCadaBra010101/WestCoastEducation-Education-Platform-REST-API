using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WestCoastEducation.Entites;
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
            var creationStudentMappedToEntityModel = _mapper.Map<Student>(student);

            _context.Entry(creationStudentMappedToEntityModel).State = EntityState.Added;
        }

        public void DeleteStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Deleted;
        }

        public async Task<IEnumerable<StudentDto>> GetAllStudentsAsync()
        {
            var result = await _context.Student.ToListAsync();
            return _mapper.Map<IEnumerable<StudentDto>>(result);
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            var student = await _context.Student.FindAsync(id);
            return student;
        }
        public async Task<StudentDto> GetStudentByPersonalNumber(string personalNumber)
        {
            var studentEntity = await _context.Student.SingleOrDefaultAsync(student => student.PersonalNumber.Equals(personalNumber));
            return _mapper.Map<StudentDto>(studentEntity);
        }

        public void UpdateStudent(JsonPatchDocument<UpdateStudentDto> patchItem, Student course)
        {
            throw new NotImplementedException();
        }
    }
}
