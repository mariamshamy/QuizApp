namespace MariamRefaatExamProject.Models
{
    public class ExamQuestions
    {
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int Order { get; set; }
    }
}
