using AutoMapper;
using System.Collections.Generic;
using WestCoastEducation.Entites;
using WestCoastEducation.Models.CourseDtos;
using WestCoastEducation.Models.StudentDtos;

namespace WestCoastEducation.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // COURSE MAPPING
            //  CreateMap<CourseDtoForCreation, Course>();
            CreateMap<UpdateCourseDto, Course>();
            CreateMap<Course, UpdateCourseDto>();
            CreateMap<CourseDto, Course>();
            CreateMap<Course, CourseDto>();
            CreateMap<CourseDtoForCreation, Course>();

            // STUDENT MAPPING
            CreateMap<StudentDtoForCreation, Student>();
            CreateMap<Student, StudentDto>();
            CreateMap<StudentDto, Student>();
            CreateMap<Student, UpdateStudentDto>();
            CreateMap<UpdateStudentDto, Student>();

        }
    }
}
