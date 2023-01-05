using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentManagement.Models
{
    public class Student_X_Course
    {
        [Key]
        public int StudentCourseId { get; set; }
        //foreignkey courseId
        [ForeignKey("Courses")]
        public int CourseId { get; set; }
        public Course Courses { get; set; }

        //foreignkey studentId
        [ForeignKey("Students")]
        public int StudentId { get; set; }
        public Student Students { get; set; }

        //foreignkey departmentId
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}