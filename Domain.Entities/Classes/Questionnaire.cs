namespace Domain.Entities.Classes
{
    /// <summary>
    /// Опрос
    /// </summary>
    public class Questionnaire
    {
        /// <summary>
        /// Идентификатор опроса.
        /// </summary>
        public string QuestionnaireId { get ; set ; }

        /// <summary>
        /// Автор опроса.
        /// </summary>
        public User Author { get ; set ; }
    }
}
