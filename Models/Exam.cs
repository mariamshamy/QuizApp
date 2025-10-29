using System.Collections.ObjectModel;

namespace MariamRefaatExamProject.Models
{
    public class Exam
    {
        public int id { get; set; }
        public Collection<ExamQuestions> examQuestions { get; set; }
        public DateTime creationDate { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }

         public int score { get; set; }
    }
}
