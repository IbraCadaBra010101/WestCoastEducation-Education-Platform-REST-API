using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WestCoastEducation.Entites;
using WestCoastEducation.Interfaces;
using WestCoastEducation.Models.CourseDtos;

namespace WestCoastEducation.Data
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CourseRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void AddCourseToRepo(CourseDtoForCreation course)
        {
            var creationCourseMappedToEntityModel = _mapper.Map<Course>(course);

            _context.Entry(creationCourseMappedToEntityModel).State = EntityState.Added;
        }

        public void DeleteCourse(Course course)
        {
            _context.Entry(course).State = EntityState.Deleted;
        }

        public async Task<IEnumerable<CourseDto>> GetAllCoursesAsync()
        {
            var result = await _context.Course.ToListAsync();
            var mapped = _mapper.Map<IEnumerable<CourseDto>>(result);
            return mapped;
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            var singleCourseEntity = await _context.Course.FindAsync(id);

            return singleCourseEntity;
        }

        public async Task<Course> GetCourseByNameAsync(string courseName)
        {
            return await _context.Course.FirstOrDefaultAsync(eachCourse => eachCourse.CourseName == courseName);
        }

        public async Task<IEnumerable<CourseDto>> GetCourseBySearchQuery(string searchQuery)
        {
            var trimmedSearchQuery = searchQuery.Trim();
            var listOfCourseMatches = await _context.Course.Where(course => course.CourseName.Contains(trimmedSearchQuery)).ToListAsync();
            var listOfCourseMatchesMappedToDto = _mapper.Map<IEnumerable<CourseDto>>(listOfCourseMatches);

            return listOfCourseMatchesMappedToDto;
        }

        public void UpdateCourse(JsonPatchDocument<UpdateCourseDto> patchItem, Course course)
        {
            var courseToPatch = _mapper.Map<UpdateCourseDto>(course);
            patchItem.ApplyTo(courseToPatch);
            var mappedCourse = _mapper.Map(courseToPatch, course);
            _context.Entry(mappedCourse).State = EntityState.Modified;
        }
    }
}
