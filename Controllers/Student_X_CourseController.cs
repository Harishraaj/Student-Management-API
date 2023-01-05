using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using StudentManagement.Data;
using StudentManagement.Models;
using StudentManagement.Services;

namespace StudentManagement.Controllers
{
    public class Student_X_CourseController : ApiController
    {
        Student_X_CourseService _student_X_CourseService;
        public Student_X_CourseController(Student_X_CourseService student_X_CourseService)
        {
            _student_X_CourseService=student_X_CourseService;
        }

        private StudentManagementContext db = new StudentManagementContext();

        [ResponseType(typeof(ArrayList))]
        [Route("api/Student_X_Course/GetMarks/{id}")]
        public ArrayList GetMarks(int id)
        {
            return _student_X_CourseService.GetMarks(id);
        }
        // GET: api/Student_X_Course
        public IQueryable<Student_X_Course> GetStudent_X_CourseDetails()
        {
            return _student_X_CourseService.GetStudent_X_CourseDetails();
        }

        // GET: api/Student_X_Course/5
        [ResponseType(typeof(Student_X_Course))]
        public Student_X_Course GetStudent_X_Course(int id)
        {
            return _student_X_CourseService.GetStudent_X_Course(id);
        }

        // PUT: api/Student_X_Course/5
        [ResponseType(typeof(void))]
        public Student_X_Course PutStudent_X_Course(Student_X_Course student_X_Course)
        {
            return _student_X_CourseService.PutStudent_X_Course(student_X_Course);
        }

        // POST: api/Student_X_Course
        [ResponseType(typeof(Student_X_Course))]
        public Student_X_Course PostStudent_X_Course(Student_X_Course student_X_Course)
        {
            return _student_X_CourseService.PostStudent_X_Course(student_X_Course);
        }

        // DELETE: api/Student_X_Course/5
        [ResponseType(typeof(Student_X_Course))]
        public bool DeleteStudent_X_Course(int id)
        {
            return _student_X_CourseService.DeleteStudent_X_Course(id);
        }
      
    }
}