using StudentManagement.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Interfaces
{
    public interface IStudent_X_CourseService
    {
        ArrayList GetMarks(int id);
        IQueryable<Student_X_Course> GetStudent_X_CourseDetails();
        Student_X_Course GetStudent_X_Course(int id);
        Student_X_Course PutStudent_X_Course(Student_X_Course student_X_Course);
        Student_X_Course PostStudent_X_Course(Student_X_Course student_X_Course);
        bool DeleteStudent_X_Course(int id);
    }
}
