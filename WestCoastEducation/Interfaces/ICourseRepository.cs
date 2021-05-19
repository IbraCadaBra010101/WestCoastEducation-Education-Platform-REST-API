using Microsoft.AspNetCore.JsonPatch;
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
        Task<Course> GetCourseByIdAsync(int id);  
        Task<Course> GetCourseByNameAsync(string courseName);  
        Task<IEnumerable<Course>> GetCourseBySearchQuery(string searchQuery);
        void DeleteCourse(Course course); 
        void UpdateCourse(JsonPatchDocument<UpdateCourseDto> patchItem, Course course);  

    } 
} 
