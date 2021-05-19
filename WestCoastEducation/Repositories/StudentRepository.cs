using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
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
        // för att patcha ett object i postman eller swagger skicka in en [] array och en eller flera objekt {}
        //[
        //    {
        //     "op": "replace",
        //     "path": "City",

        //     "value": "Montevideo"
        //    }
        //]
        // I SWAGGER 
        //        [
        //  {
        //    "operationType": 0, 
        //    "path": "string",
        //    "op": "string",
        //    "from": "string"
        //  }
        //      ]

//        [
//  {
//    "operationType": 2,
//    "path": "city",
//    "op": "replace",
//    "value": "Paris"
//  }
//]
        //FIELDS
        //Add	0	
        //Copy	4	
        //Invalid	6	    
        //Move	3	
        //Remove	1	
        //Replace	2	
        //Test	5

        public void UpdateStudent(JsonPatchDocument<UpdateStudentDto> patchItem, Student student)
        {
            var studentToPatch = _mapper.Map<UpdateStudentDto>(student);
            patchItem.ApplyTo(studentToPatch);
            var mappedStudent = _mapper.Map(studentToPatch, student);
            _context.Entry(mappedStudent).State = EntityState.Modified;
        }
    }
}
