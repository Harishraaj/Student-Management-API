using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace StudentManagement.Interfaces
{
    public  interface IStaff_X_CourseRepository
    {
        IQueryable<Staff_X_Course> GetStaff_X_CourseDetails();
        Staff_X_Course GetStaff_X_Course(int id);
        Staff_X_Course PutStaff_X_Course(Staff_X_Course staff_X_Course);
        Staff_X_Course PostStaff_X_Course(Staff_X_Course staff_X_Course);
        bool DeleteStaff_X_Course(int id);

    }
}
