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
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.Services;

namespace StudentManagement.Controllers
{
    public class CourseController : ApiController
    {
        ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        private StudentManagementContext db = new StudentManagementContext();

        // GET: api/Course
        public IQueryable<Course> GetCourseDetails()
        {
            return _courseService.GetCourseDetails();
        }

        // GET: api/Course/5
        [ResponseType(typeof(Course))]
        public Course GetCourse(int id)
        {
            return _courseService.GetCourse(id);
        }

        // PUT: api/Course/5
        [ResponseType(typeof(void))]
        public Course PutCourse( Course course)
        {
            return _courseService.PutCourse(course);
        }

        // POST: api/Course
        [ResponseType(typeof(Course))]
        public Course PostCourse(Course course)
        {
            return _courseService.PostCourse(course);
        }

        // DELETE: api/Course/5
        [ResponseType(typeof(Course))]
        public bool DeleteCourse(int id)
        {
            return _courseService.DeleteCourse(id);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

       
    }
}