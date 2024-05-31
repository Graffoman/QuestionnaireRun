using Domain.Entities.Interfaces;


namespace Domain.Entities.Classes
{
    /// <summary>
    /// Ответы на опрос
    /// </summary>
    public class QuestionnaireSubmit : IEntity
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Пользователь.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Автор опроса
        /// </summary>
        public User Author { get; set; }

        /// <summary>
        /// Наполнение опроса
        /// </summary>
        public QuestionnaireRun QuestionnaireRun { get; set; }

        /// <summary>
        /// Время ответа на опрос.
        /// </summary>
        public DateTime SubmitDate { get; set; }

        /// <summary>
        /// Ответы.
        /// </summary>
        public string Answers {  get; set; }
    }
}
