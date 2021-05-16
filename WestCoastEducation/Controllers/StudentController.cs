using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WestCoastEducation.Interfaces;
using WestCoastEducation.Models.StudentDtos;

namespace WestCoastEducation.Controllers
{
    [ApiController]
    [Route("api/Student")]

    public class StudentController : ControllerBase 
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
         
        // GET: api/Course
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentDto>>> GetStudentDto()
        { 
            var result = await _unitOfWork.StudentRepository.GetAllStudentsAsync();
            if (result == null) return StatusCode(500, "This category was not found");
            return Ok(result);
        }

        // GET: api/Course/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDto>> GetStudentDto(int id)
        {
            var result = await _unitOfWork.StudentRepository.GetStudentByIdAsync(id);
            if (result == null) return NotFound(); 
            return Ok(result);
        }

        // PATCH: api/Course/5

        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchStudentDto(int id, UpdateStudentDto studentModelUpdate)
        { 
            try
            {
                var result = _unitOfWork.StudentRepository.GetStudentByIdAsync(id);


                if (result == null) return StatusCode(404, "Could not find the student you requested an update on");

                _unitOfWork.StudentRepository.UpdateStudent(studentModelUpdate);

                if (await _unitOfWork.Complete()) return NoContent();

                return StatusCode(500, $"Could not update student nr {id}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
 
        // POST: api/Course
        [HttpPost] 
        public async Task<ActionResult<StudentDto>> PostCourseDto(StudentDtoForCreation studentDto)
        {
            try
            {

                var result =  _unitOfWork.StudentRepository.GetStudentByPersonalNumber(studentDto.PersonalNumber);
                if (result != null) return StatusCode(404, $"A student with the personal number {studentDto.PersonalNumber} already exists in the system.");
             
                _unitOfWork.StudentRepository.AddStudentToRepo(studentDto);
                if (await _unitOfWork.Complete()) return StatusCode(201, "Succesfull, a new student resource was created");
                return StatusCode(500, "Could not save student resource");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        // DELETE: api/Course/5

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourseDto(int id)
        {
            try
            {
                var courseToDelete = await _unitOfWork.CourseRepository.GetCourseByIdAsync(id);

                if (courseToDelete == null) return NotFound($"Could not find course with id number {id}. Operation was canceled");
                _unitOfWork.CourseRepository.DeleteCourse(courseToDelete);

                if (await _unitOfWork.Complete()) return StatusCode(200, $"{courseToDelete.CourseName} was succesfully deleted");
                return StatusCode(500, $"Could not delete {courseToDelete.CourseName}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
