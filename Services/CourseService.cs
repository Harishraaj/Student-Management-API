using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.Repository;
using System.Linq;


namespace StudentManagement.Services
{
    public class CourseService : ICourseService
    {
        ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository= courseRepository;
        }

        public Course GetCourse(int id)
        {
            return _courseRepository.GetCourse(id);
        }
        public IQueryable<Course> GetCourseDetails()
        {
            return _courseRepository.GetCourseDetails();
        }
        public Course PutCourse(Course course)
        {
            return _courseRepository.PutCourse(course);
        }
        public bool DeleteCourse(int id)
        {
            return _courseRepository.DeleteCourse(id);
        }
        public Course PostCourse(Course course)
        {
            return _courseRepository.PostCourse(course);
        }
    }
}