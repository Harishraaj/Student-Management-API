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
using System.Web.Http.Description;
using System.Collections;

namespace StudentManagement.Repository
{
    public class Student_X_CourseRepository :ApiController,IStudent_X_CourseRepository
    {
        private StudentManagementContext db = new StudentManagementContext();

        [ResponseType(typeof(ArrayList))]
        public ArrayList GetMarks(int id)
        {
            //String name, code,status;
            float total = 0;
            int count = 0;
            Student student = db.Students.Find(id);
            ArrayList list = new ArrayList();
            ArrayList course = new ArrayList();
            ArrayList courseMark = new ArrayList();
            foreach (Result rs in db.Results)
            {
                if (rs.StudentId == id)
                {
                    courseMark.Add(rs.Mark);
                    total += rs.Mark;
                    count++;
                    courseMark.Add("  ");
                }
            }
            foreach (Student_X_Course item in db.Student_X_Course)
            {
                if (item.StudentId == id)
                {
                    int courseId = item.CourseId;
                    string name = (db.Courses.Find(courseId)).CourseName;
                    course.Add(name);
                    course.Add("  ");
                }
            }
            list.Add(student.StudentId);
            list.Add(student.StudentName);
            list.Add(course);
            list.Add(courseMark);
            list.Add(total);
            list.Add(count * 100);
            return list;
        }

        // GET: api/Student_X_Course
        public IQueryable<Student_X_Course> GetStudent_X_CourseDetails()
        {
            return db.Student_X_Course;
        }

        // GET: api/Student_X_Course/5
        [ResponseType(typeof(Student_X_Course))]
        public Student_X_Course GetStudent_X_Course(int id)
        {
            Student_X_Course student_X_Course = db.Student_X_Course.Find(id);
            if (student_X_Course == null)
            {
                throw new Exception("Not found");
            }

            return student_X_Course;
        }

        // PUT: api/Student_X_Course/5
        [ResponseType(typeof(void))]
        public Student_X_Course PutStudent_X_Course(Student_X_Course student_X_Course)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("Invalid Data");
            }
            if (student_X_Course.StudentCourseId<=0)
            {
                throw new Exception("Invalid Id");
            }
            db.Entry(student_X_Course).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Student_X_CourseExists(student_X_Course.StudentCourseId))
                {
                    throw new Exception("Not found");
                }
                else
                {
                    throw;
                }
            }

            return student_X_Course;
        }

        // POST: api/Student_X_Course
        [ResponseType(typeof(Student_X_Course))]
        public Student_X_Course PostStudent_X_Course(Student_X_Course student_X_Course)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("bad request");
            }
            try
            {
                db.Student_X_Course.Add(student_X_Course);
                db.SaveChanges();
                return student_X_Course;
            }
            catch
            {
                throw new Exception("Unable to send post request");
            }
        }

        // DELETE: api/Student_X_Course/5
        [ResponseType(typeof(Student_X_Course))]
        public bool DeleteStudent_X_Course(int id)
        {
            Student_X_Course student_X_Course = db.Student_X_Course.Find(id);
            if (student_X_Course == null)
            {
                throw new Exception("Not found");
            }

            db.Student_X_Course.Remove(student_X_Course);
            db.SaveChanges();

            return true;
        }
        private bool Student_X_CourseExists(int id)
        {
            return db.Student_X_Course.Count(e => e.StudentCourseId == id) > 0;
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