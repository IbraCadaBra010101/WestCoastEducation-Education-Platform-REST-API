using System.Collections.Generic;
using System.Threading.Tasks;
using WestCoastEducation.Models.CourseDtos;

namespace WestCoastEducation.Interfaces
{
    public interface ICourseRepository
    {
        void AddCourseToRepo(CourseDtoForCreation course);
        Task<IEnumerable<CourseDto>> GetAllCoursesAsync();
        Task<CourseDto> GetCourseByIdAsync();  
        Task<CourseDto> GetCourseByNameAsync(); 
        void DeleteCourse(CourseDto course);
        void UpdateCoursee(UpdateCourseDto course);
    } 
} 
