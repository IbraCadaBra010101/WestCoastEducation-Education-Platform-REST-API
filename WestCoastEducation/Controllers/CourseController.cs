using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WestCoastEducation.Data;
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
            return Ok()
        }

        // PUT: api/Course/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourseDto(int id, CourseDto courseDto)
        {
            if (id != courseDto.Id)
            {
                return BadRequest();
            }

            _context.Entry(courseDto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseDtoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Course
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CourseDto>> PostCourseDto(CourseDto courseDto)
        {
            _context.CourseDto.Add(courseDto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCourseDto", new { id = courseDto.Id }, courseDto);
        }

        // DELETE: api/Course/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourseDto(int id)
        {
            var courseDto = await _context.CourseDto.FindAsync(id);
            if (courseDto == null)
            {
                return NotFound();
            }

            _context.CourseDto.Remove(courseDto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CourseDtoExists(int id)
        {
            return _context.CourseDto.Any(e => e.Id == id);
        }
    }
}
