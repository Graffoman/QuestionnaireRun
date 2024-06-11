
namespace Domain.Entities.Interfaces
{
    public interface IEntityPostgresDB<TId>
    {
        TId Id { get; set; }
    }
}
