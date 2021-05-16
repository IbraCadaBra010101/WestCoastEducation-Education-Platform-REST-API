using System.Collections.Generic;
using System.Threading.Tasks;
using WestCoastEducation.Models.CourseDtos;

namespace WestCoastEducation.Interfaces
{
    public interface ICourseRepository
    {
        void AddCourseToRepo(CourseDtoForCreation course);
        Task<IEnumerable<CourseDto>> GetAllCoursesAsync();
        Task<CourseDto> GetCourseByIdAsync(int id);  
        Task<CourseDto> GetCourseByNameAsync(string courseName); 
        void DeleteCourse(CourseDto course); 
        void UpdateCourse(UpdateCourseDto courseModelUpdate); 
    } 
} 
