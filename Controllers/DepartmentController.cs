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
    public class DepartmentController : ApiController
    {
        IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        // GET: api/Department
        public IQueryable<Department> GetDepartments()
        {
            return _departmentService.GetDepartmentDetails();
        }

        // GET: api/Department/5
        [ResponseType(typeof(Department))]

        public Department GetDepartment(int id)
        {
            return _departmentService.GetDepartment(id) ;
        }
        // PUT: api/Department/5
        [ResponseType(typeof(Department))]
        public Department PutDepartment(Department department)
        {
            return _departmentService.PutDepartment( department);
        }

        // POST: api/Department
        [ResponseType(typeof(Department))]
        public Department PostDepartment(Department department)
        {
            return _departmentService.PostDepartment(department);
        }
        // DELETE: api/Department/5
        [ResponseType(typeof(Department))]
        public bool DeleteDepartment(int id)
        {
            return _departmentService.DeleteDepartment(id);
        }
    }
}