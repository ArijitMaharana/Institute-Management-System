using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCLabTaskLayout.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }



        [Required(ErrorMessage = "Course name is required")]
        [StringLength(100)]
        public string Name { get; set; }



        [Required(ErrorMessage = "Course fees are required")]
        [Range(0, 1000000, ErrorMessage = "Fees must be a positive value")]
        public double Fees { get; set; }



        [Required(ErrorMessage = "Course duration is required")]
        [StringLength(50)]
        public string Duration { get; set; }


        // Navigation property
        public ICollection<Student> Students { get; set; }

    }
}