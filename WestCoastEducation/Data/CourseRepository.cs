using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            throw new NotImplementedException();
        }

        public void DeleteCourse(CourseDto course)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CourseDto>> GetAllCoursesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CourseDto> GetCourseByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CourseDto> GetCourseByNameAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateCoursee(UpdateCourseDto course)
        {
            throw new NotImplementedException();
        }
    }
}
