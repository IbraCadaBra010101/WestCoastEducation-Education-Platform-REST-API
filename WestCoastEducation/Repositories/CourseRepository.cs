using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
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

        public void DeleteCourse(CourseDto course)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CourseDto>> GetAllCoursesAsync()
        {
            var result = await  _context.Course.ToListAsync();
            return _mapper.Map<IEnumerable<CourseDto>>(result);
        }

        public async Task<CourseDto> GetCourseByIdAsync(int id)
        {
            var singleCourseEntity = await _context.Course.FindAsync(id);
            var mappedTowardCourseDto = _mapper.Map<CourseDto>(singleCourseEntity);
            return mappedTowardCourseDto;
        }

        public async Task<Course> GetCourseByNameAsync(string courseName)
        {
          return await _context.Course.FirstOrDefaultAsync(eachCourse => eachCourse.CourseName == courseName);
        }

        public void UpdateCourse(UpdateCourseDto courseModelUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
