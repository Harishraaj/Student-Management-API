using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagement.Models
{
    public class Result
    {
        [Key]
        public int ResultId { get; set; }

        [ForeignKey("Students")]
        public int StudentId { get; set; }
        public Student Students { get; set; }



        [ForeignKey("Courses")]
        public int CourseId { get; set; }
        public Course Courses { get; set; }

        [Required]
        public float Mark { get; set; }

        [Required]
        public string Status { get; set; }
    }
}