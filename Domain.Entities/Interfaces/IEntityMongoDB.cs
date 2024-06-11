namespace Domain.Entities.Interfaces
{
    /// <summary>
    /// Интерфейс сущности с идентификатором.
    /// </summary>
    public interface IEntityMongoDB
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public string Id { get; set; }
    }
}
