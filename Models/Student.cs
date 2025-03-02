using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentDatabaseApp.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        
        [Required]
        public string FirstName { get; set; } = string.Empty;
        
        [Required]
        public string LastName { get; set; } = string.Empty;
        
        public DateTime EnrollmentDate { get; set; }
        
        public string Email { get; set; } = string.Empty;
    }
} 