using StudentManagement.Data;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http.Description;
using System.Web.Http;
using StudentManagement.Interfaces;
using Microsoft.Ajax.Utilities;

namespace StudentManagement.Repository
{
    public class Staff_X_CourseRepository : ApiController,IStaff_X_CourseRepository
    {
        private StudentManagementContext db = new StudentManagementContext();

        // GET: api/Staff_X_Course
        public IQueryable<Staff_X_Course> GetStaff_X_CourseDetails()
        {
            return db.Staff_X_Course;
        }

        // GET: api/Staff_X_Course/5
        [ResponseType(typeof(Staff_X_Course))]
        public Staff_X_Course GetStaff_X_Course(int id)
        {
            Staff_X_Course staff_X_Course = db.Staff_X_Course.Find(id);
            if (staff_X_Course == null)
            {
                throw new Exception("not found");
            }

            return staff_X_Course;
        }

        // PUT: api/Staff_X_Course/5
        [ResponseType(typeof(void))]
        public Staff_X_Course PutStaff_X_Course(Staff_X_Course staff_X_Course)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("Invalid Data");
            }
            if (staff_X_Course.StaffCourseId<=0)
            {
                throw new Exception("Invalid Id");
            }
            db.Entry(staff_X_Course).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Staff_X_CourseExists(staff_X_Course.StaffCourseId))
                {
                    throw new Exception("not found");
                }
                else
                {
                    throw;
                }
            }

            return staff_X_Course;
        }

        // POST: api/Staff_X_Course
        [ResponseType(typeof(Staff_X_Course))]
        public Staff_X_Course PostStaff_X_Course(Staff_X_Course staff_X_Course)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("Its a bad request");
            }
            try
            {
                db.Staff_X_Course.Add(staff_X_Course);
                db.SaveChanges();
                return staff_X_Course;
            }
            catch
            {
                throw new Exception("Unable to send post request");
            }
        }

        // DELETE: api/Staff_X_Course/5
        [ResponseType(typeof(Staff_X_Course))]
        public bool DeleteStaff_X_Course(int id)
        {
            Staff_X_Course staff_X_Course = db.Staff_X_Course.Find(id);
            if (staff_X_Course == null)
            {
                throw new Exception("not found");
            }

            db.Staff_X_Course.Remove(staff_X_Course);
            db.SaveChanges();

            return true;
        }
        private bool Staff_X_CourseExists(int id)
        {
            return db.Staff_X_Course.Count(e => e.StaffCourseId == id) > 0;
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