using System.Collections.Generic;
using System.Threading.Tasks;
using WestCoastEducation.Entites;
using WestCoastEducation.Models.CourseDtos;

namespace WestCoastEducation.Interfaces
{
    public interface ICourseRepository
    {
        void AddCourseToRepo(CourseDtoForCreation course);
        Task<IEnumerable<CourseDto>> GetAllCoursesAsync();
        Task<CourseDto> GetCourseByIdAsync(int id);  
        Task<Course> GetCourseByNameAsync(string courseName); 
        void DeleteCourse(CourseDto course); 
        void UpdateCourse(UpdateCourseDto courseModelUpdate, int id); 
    } 
} 
