using System.Collections.Generic;
using System.Threading.Tasks;
using WestCoastEducation.Models.CourseDtos;

namespace WestCoastEducation.Interfaces
{
    public interface ICourseRepository
    {
        void AddCourseToRepo(CourseDtoForCreation course);
        Task<IEnumerable<CourseDto>> GetAllCoursesAsync();
        Task<IEnumerable<CourseDto>> GetAllCoursesByIdAsync();
        void Delete(CourseDto course);
        void Update(UpdateCourseDto course);
    }
}
