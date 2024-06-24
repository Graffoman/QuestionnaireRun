using Domain.Entities.Classes;

namespace Services.Contracts.QuestionnaireSubmitDto
{
    /// <summary>
    /// ДТО ответа на опрос
    /// </summary>
    public class CreateQuestionnaireSubmitDto
    {
        public User User { get; set; }
        public User Author { get; set; }
        public QuestionnaireRun QuestionnaireRun { get; set; }
        public DateTime SubmitDate { get; set; }
        public string Answers { get; set; }
    }
}
