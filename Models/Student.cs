using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace MariamRefaatExamProject.Models
{ 
    public class Student
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Student Name required! ")]
        public string name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Student Age required! ")]
        [Range(1, 150, ErrorMessage = "Student Age must be bigger  than 0")]
        public int age { get; set; }
        public Collection<Exam> exams { get; set; }
    }
}
