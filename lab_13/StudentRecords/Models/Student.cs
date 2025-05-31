using System;
using System.ComponentModel.DataAnnotations;

namespace StudentRecords.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Roll Number is required")]
        [Display(Name = "Roll Number")]
        [RegularExpression(@"^[A-Z]{2}\d{3}$", ErrorMessage = "Roll Number must be in format XX999")]
        public string RollNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "GPA is required")]
        [Range(0.0, 4.0, ErrorMessage = "GPA must be between 0.0 and 4.0")]
        [Display(Name = "GPA")]
        public double GPA { get; set; }
    }
}