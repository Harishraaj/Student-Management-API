using StudentManagement.Data;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace StudentManagement.Repository
{
    public class DepartmentRepository : ApiController,IDepartmentRepository
    {
        private StudentManagementContext db = new StudentManagementContext();
        public Department GetDepartment(int id)
        {
            Department department = db.Departments.Find(id);
            if (department == null)
            {
                throw new Exception(" Department Not Found ");
            }
            return department;
        }
        public IQueryable<Department> GetDepartmentDetails()
        {
            return db.Departments;
        }
        public Department PutDepartment(Department department)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("Invalid Department Data");
            }
            if (department.DepartmentId<=0)
            {
                throw new Exception("Invalid Department ID");
            }
            db.Entry(department).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentExists(department.DepartmentId))
                {
                    throw new Exception(" Department Not Found ");
                }
                else
                {
                    throw;
                }
            }
            return department;
        }
        public Department PostDepartment(Department department)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("bad request");
            }
            try
            {
                db.Departments.Add(department);
                db.SaveChanges();
                return department;
            }
            catch
            {
                throw new Exception("Unable to send post request");
            }
        }
        public bool DeleteDepartment(int id)
        {
            Department department = db.Departments.Find(id);
            if (department == null)
            {
                throw new Exception(" Department Not Found ");
            }

            db.Departments.Remove(department);
            db.SaveChanges();
            return true;
        }
        private bool DepartmentExists(int id)
        {
            return db.Departments.Count(e => e.DepartmentId == id) > 0;
        }
       
    }
}