using StudentManagement.Interfaces;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using StudentManagement.Repository;
using System.Collections;

namespace StudentManagement.Services
{
    public class Student_X_CourseService: IStudent_X_CourseService
    {
        IStudent_X_CourseRepository _student_X_CourseRepository;
        public Student_X_CourseService(IStudent_X_CourseRepository student_X_CourseRepository)
        {
            _student_X_CourseRepository = student_X_CourseRepository;
        }

        public ArrayList GetMarks(int id)
        {
            return _student_X_CourseRepository.GetMarks(id);
        }
        public IQueryable<Student_X_Course> GetStudent_X_CourseDetails()
        {
            return _student_X_CourseRepository.GetStudent_X_CourseDetails();    
        }
        public Student_X_Course GetStudent_X_Course(int id)
        {
            return _student_X_CourseRepository.GetStudent_X_Course(id);
        }
        public Student_X_Course PutStudent_X_Course(Student_X_Course student_X_Course)
        {
            return _student_X_CourseRepository.PutStudent_X_Course(student_X_Course);
        }
        public Student_X_Course PostStudent_X_Course(Student_X_Course student_X_Course)
        {
            return _student_X_CourseRepository.PostStudent_X_Course(student_X_Course);
        }
        public bool DeleteStudent_X_Course(int id)
        {
            return _student_X_CourseRepository.DeleteStudent_X_Course(id);
        }
    }
}