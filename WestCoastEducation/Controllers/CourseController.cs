using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WestCoastEducation.Interfaces;
using WestCoastEducation.Models.CourseDtos;

namespace WestCoastEducation.Controllers
{
    [ApiController]
    [Route("api/Course")]

    public class CourseController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CourseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Course
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetCourseDto()
        {
            var result = await _unitOfWork.CourseRepository.GetAllCoursesAsync();
            if (result == null) return StatusCode(500, "This category was not found");
            return Ok(result);
        }

        // GET: api/Course/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CourseDto>> GetCourseDto(int id)
        {
            var result = await _unitOfWork.CourseRepository.GetCourseByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        // PATCH: api/Course/5

        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchCourseDto(int id, UpdateCourseDto courseModelUpdate)
        {
            try
            {
                var result = _unitOfWork.CourseRepository.GetCourseByIdAsync(id);


                if (result == null) return StatusCode(404, "Could not find the course you requested an update on");

                _unitOfWork.CourseRepository.UpdateCourse(courseModelUpdate);

                if (await _unitOfWork.Complete()) return NoContent();

                return StatusCode(500, $"Could not update course nr {id}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST: api/Course
        [HttpPost]
        public async Task<ActionResult<CourseDto>> PostCourseDto(CourseDtoForCreation courseDto)
        {
            try
            {
                var result = await _unitOfWork.CourseRepository.GetCourseByNameAsync(courseDto.CourseName);
                if (result.CourseName == courseDto.CourseName) return BadRequest($"Kursen {courseDto.CourseName} existerar redan!");

                _unitOfWork.CourseRepository.AddCourseToRepo(courseDto);
                if (await _unitOfWork.Complete()) return StatusCode(201, "Succesfull, a new course resource was created");
                return StatusCode(500, "Could not save course resource");
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
