using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Interfaces
{
    public interface ICourseService
    {
        Course GetCourse(int id);
        IQueryable<Course> GetCourseDetails();
        Course PutCourse(Course course);
        bool DeleteCourse(int id);
        Course PostCourse(Course course);
    }
}
