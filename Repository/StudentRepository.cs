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

namespace StudentManagement.Repository
{
    public class StudentRepository :ApiController,IStudentRepository
    {
        private StudentManagementContext db = new StudentManagementContext();
        public Student GetStudent(int id)
        {
            Student student = db.Students.Find(id);
            if (student == null)
            {
                throw new Exception(" Student Not Found ");
            }
            return student;
        }
        public IQueryable<Student> GetStudentDetails()
        {
            return db.Students;
        }
        public Student PostStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("Its a bad request");
            }
            try
            {
                db.Students.Add(student);
                db.SaveChanges();
                return student;
            }
            catch
            {
                throw new Exception("unable to send post request");
            } 
        }
        public bool DeleteStudent(int id)
        {
            Student student = db.Students.Find(id);
            if (student == null)
            {
                throw new Exception("Not Found");
            }

            db.Students.Remove(student);
            db.SaveChanges();
            return true;
        }
        public Student PutStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("Invalid Data");
            }
            if (student.StudentId<=0)
            {
                throw new Exception("Invalid Student Id");
            }
            db.Entry(student).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(student.StudentId))
                {
                    throw new Exception("Not Found");
                }
                else
                {
                    throw;
                }
            }
            return student;
        }
        private bool StudentExists(int id)
        {
            return db.Students.Count(e => e.StudentId == id) > 0;
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