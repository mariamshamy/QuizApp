using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace MariamRefaatExamProject.Models
{
    public class Question
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Question title is required! ")]
        public string title { get; set; } = string.Empty;
        public Collection<Choice> choices { get; set; }
        public Collection<ExamQuestions> examQuestions { get; set; }
    }
}
