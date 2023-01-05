                                                                                                                                                                  using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace StudentManagement.Services
{
    public class Staff_X_CourseService : IStaff_X_CourseService
    {
        IStaff_X_CourseRepository _staff_x_course_repository;
        public Staff_X_CourseService(IStaff_X_CourseRepository staff_x_course_repository)
        {
            _staff_x_course_repository = staff_x_course_repository;
        }

        public IQueryable<Staff_X_Course> GetStaff_X_CourseDetails()
        {
            return _staff_x_course_repository.GetStaff_X_CourseDetails();
        }
        public Staff_X_Course GetStaff_X_Course(int id)
        {
            return _staff_x_course_repository.GetStaff_X_Course(id);
        }
        public Staff_X_Course PutStaff_X_Course(Staff_X_Course staff_X_Course)
        {
            return _staff_x_course_repository.PutStaff_X_Course(staff_X_Course);
        }
        public Staff_X_Course PostStaff_X_Course(Staff_X_Course staff_X_Course)
        {
            return _staff_x_course_repository.PostStaff_X_Course(staff_X_Course);
        }
        public bool DeleteStaff_X_Course(int id)
        {
            return _staff_x_course_repository.DeleteStaff_X_Course(id);
        }
    }
}