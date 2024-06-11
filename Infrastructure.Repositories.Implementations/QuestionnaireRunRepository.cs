using Domain.Entities.Classes;
using Infrastructure.DataAcess;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Implementations
{
    public class QuestionnaireRunRepository : RepositoryMongoDB<QuestionnaireRun>, IQuestionnaireRunRepository  
    {
        public QuestionnaireRunRepository(MongoDB<QuestionnaireRun> db) : base(db)
        {

        }
    }
}
