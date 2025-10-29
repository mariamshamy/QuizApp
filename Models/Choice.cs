namespace MariamRefaatExamProject.Models
{
    public class Choice
    {
        public int id { get; set; }
        public string option { get; set; } = string.Empty;
        public bool isCorrect { get; set; }
        public int questionID { get; set; }
        public Question question { get; set; }
    }
}
