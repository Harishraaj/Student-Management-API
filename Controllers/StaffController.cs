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
    public class StaffController : ApiController
    {
        StaffService _staffService;
        public StaffController(StaffService staffService)
        {
            _staffService = staffService;
        }


        // GET: api/Staff
        public IQueryable<Staff> GetStaffDetails()
        {
            return _staffService.GetStaffDetails();
        }

        // GET: api/Staff/5
        [ResponseType(typeof(Staff))]
        public Staff GetStaff(int id)
        {
            return _staffService.GetStaff(id);
        }

        // PUT: api/Staff/5
        [ResponseType(typeof(void))]
        public Staff PutStaff(Staff staff)
        {
            return _staffService.PutStaff(staff);
        }

        // POST: api/Staff
        [ResponseType(typeof(Staff))]
        public Staff PostStaff(Staff staff)
        {
           return _staffService.PostStaff(staff);
        }

        // DELETE: api/Staff/5
        [ResponseType(typeof(Staff))]
        public bool DeleteStaff(int id)
        {
           return  _staffService.DeleteStaff(id);
        }
    }
}