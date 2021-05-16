using AutoMapper;
using WestCoastEducation.Entites;
using WestCoastEducation.Models;
using WestCoastEducation.Models.CourseDtos;

namespace WestCoastEducation.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
       
            CreateMap<CourseDtoForCreation, Course>();
            CreateMap<UpdateCourseDto, Course>();
            CreateMap<CourseDto, Course>();
            CreateMap<Course, CourseDto>();

        }
    }
}
