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
    public class Staff_X_CourseController : ApiController
    {
        IStaff_X_CourseService _staff_X_CourseService;
        public Staff_X_CourseController(IStaff_X_CourseService staff_X_CourseService)
        {
            _staff_X_CourseService = staff_X_CourseService;
        }



        // GET: api/Staff_X_Course
        public IQueryable<Staff_X_Course> GetStaff_X_CourseDetails()
        {
            return _staff_X_CourseService.GetStaff_X_CourseDetails();
        }

        // GET: api/Staff_X_Course/5
        [ResponseType(typeof(Staff_X_Course))]
        public Staff_X_Course GetStaff_X_Course(int id)
        {
            return _staff_X_CourseService.GetStaff_X_Course(id);
        }

        // PUT: api/Staff_X_Course/5
        [ResponseType(typeof(void))]
        public Staff_X_Course PutStaff_X_Course(Staff_X_Course staff_X_Course)
        {
            return _staff_X_CourseService.PutStaff_X_Course(staff_X_Course);
        }

        // POST: api/Staff_X_Course
        [ResponseType(typeof(Staff_X_Course))]
        public Staff_X_Course PostStaff_X_Course(Staff_X_Course staff_X_Course)
        {
            return _staff_X_CourseService.PostStaff_X_Course(staff_X_Course);
        }

        // DELETE: api/Staff_X_Course/5
        [ResponseType(typeof(Staff_X_Course))]
        public bool DeleteStaff_X_Course(int id)
        {
           return _staff_X_CourseService.DeleteStaff_X_Course(id);
        }

    }
}