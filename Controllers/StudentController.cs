using System;
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
    public class StudentController : ApiController
    {
        StudentService _studentService;
        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }
         
        [ResponseType(typeof(Student))]
        public Student GetStudent(int id)
        {
            return _studentService.GetStudent(id);
        }

        private StudentManagementContext db = new StudentManagementContext();
        // GET: api/Student
        public IQueryable<Student> GetStudents()
        {
            return _studentService.GetStudentDetails();
        }

        // PUT: api/Student/5
        [ResponseType(typeof(void))]
       
        public Student PutStudent(Student student)
        {
            return _studentService.PutStudent(student);
        }

        // POST: api/Student
        [ResponseType(typeof(Student))]
        public  Student PostStudent(Student student)
        {
            return _studentService.PostStudent(student);
        }

        // DELETE: api/Student/5
        [ResponseType(typeof(Student))]
        public bool DeleteStudent(int id)
        {
            return _studentService.DeleteStudent(id);
        }
       
    }
}