using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentManagement.Models
{
    public class Staff_X_Course
    {
        [Key]
        public int StaffCourseId { get; set; }

        //foreignkey staffId
        [ForeignKey("Staff")]
        public int StaffId { get; set; }
        public Staff Staff { get; set; }

        //foreignkey courseId
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}