using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentManagement.Data
{
    public class StudentManagementContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public StudentManagementContext() : base("name=StudentManagementContext")
        {
        }

        public System.Data.Entity.DbSet<StudentManagement.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<StudentManagement.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<StudentManagement.Models.Result> Results { get; set; }

        public System.Data.Entity.DbSet<StudentManagement.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<StudentManagement.Models.Staff> Staffs { get; set; }

        public System.Data.Entity.DbSet<StudentManagement.Models.Student_X_Course> Student_X_Course { get; set; }

        public System.Data.Entity.DbSet<StudentManagement.Models.Staff_X_Course> Staff_X_Course { get; set; }
    }
}
