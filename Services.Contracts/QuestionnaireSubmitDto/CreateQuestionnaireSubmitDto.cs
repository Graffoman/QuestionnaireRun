using Domain.Entities.Classes;

namespace Services.Contracts.QuestionnaireSubmitDto
{
    /// <summary>
    /// ДТО ответа на опрос
    /// </summary>
    internal class CreateQuestionnaireSubmitDto
    {
        /// <summary>
        /// ДТО дентификатора.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// ДТО пользователя.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// ДТО автор опроса.
        /// </summary>
        public User Author { get; set; }

        /// <summary>
        /// ДТО запуска опроса.
        /// </summary>
        public QuestionnaireRun QuestionnaireRun { get; set; }

        /// <summary>
        /// ДТО времени ответа на опрос.
        /// </summary>
        public DateTime SubmitDate { get; set; }

        /// <summary>
        /// ДТО ответов.
        /// </summary>
        public string Answers { get; set; }
    }
}
