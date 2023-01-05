using StudentManagement.Data;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace StudentManagement.Repository
{
    public class StaffRepository : ApiController, IStaffRepository
    {
        private StudentManagementContext db = new StudentManagementContext();
        public Staff GetStaff(int id)
        {
            Staff staff = db.Staffs.Find(id);
            if (staff == null)
            {
                throw new Exception(" Staff Not Found ");
            }

            return staff;
        }
        public IQueryable<Staff> GetStaffDetails()
        {
            return db.Staffs;
        }
        public Staff PostStaff(Staff staff)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("bad request");
            }
            try
            {
                db.Staffs.Add(staff);
                db.SaveChanges();
                return staff;
            }
            catch
            {
                throw new Exception(" Staff Not Found ");
            }
        }
        public Staff PutStaff(Staff staff)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("Invalid data");
            }
            if (staff.StaffId<=0)
            {
                throw new Exception("Invalid Staff Id");
            }
            db.Entry(staff).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StaffExists(staff.StaffId))
                {
                    throw new Exception(" Staff Not Found ");
                }
                else
                {
                    throw;
                }
            }

            return staff;
        }
        public bool DeleteStaff(int id)
        {
            Staff staff = db.Staffs.Find(id);
            if (staff == null)
            {
                throw new Exception("Not found");
            }

            db.Staffs.Remove(staff);
            db.SaveChanges();

            return true;
        }
       
        private bool StaffExists(int id)
        {
            return db.Staffs.Count(e => e.StaffId == id) > 0;
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