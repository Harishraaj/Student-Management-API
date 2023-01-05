using StudentManagement.Data;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;


namespace StudentManagement.Repository
{
    public class CourseRepository :ApiController, ICourseRepository
    {
        private StudentManagementContext db = new StudentManagementContext();
        public Course GetCourse(int id)
        {
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                throw new Exception("Not found");
            }
            return course;
        }
        public IQueryable<Course> GetCourseDetails()
        {
            return db.Courses;
        }
        public Course PutCourse(Course course)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("Invalid Course Data");
            }
            if (course.CourseId<=0)
            {
                throw new Exception("Invalid Course ID");
            }
            db.Entry(course).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseExists(course.CourseId))
                {
                    throw new Exception("Not found");
                }
                else
                {
                    throw;
                }
            }
            return course;
        }
        public bool DeleteCourse(int id)
        {
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                throw new Exception("Not found");
            }

            db.Courses.Remove(course);
            db.SaveChanges();
            return true;
        }
        public Course PostCourse(Course course)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("bad request");
            }
            try
            {
                db.Courses.Add(course);
                db.SaveChanges();
                return course;
            }
            catch
            {
                throw new Exception("Unable to send post request");
            }
            
        }
        
        private bool CourseExists(int id)
        {
            return db.Courses.Count(e => e.CourseId == id) > 0;
        }

    }
}