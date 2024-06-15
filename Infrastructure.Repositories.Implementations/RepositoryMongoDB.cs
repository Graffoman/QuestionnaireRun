using Domain.Entities.Interfaces;
using Infrastructure.DataAcess;
using MongoDB.Bson;
using MongoDB.Driver;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Implementations
{
    public abstract class RepositoryMongoDB<T> : IRepositoryMongoDB<T>
        where T : class, IEntityMongoDB
    {
        protected readonly MongoDB<T> Db;
        private readonly IMongoCollection<T> Collection;

        protected RepositoryMongoDB(MongoDB<T> db)
        {
            Db = db;
            Collection = db.Collection;
        }

        public virtual T Add(T entity)
        {
            Collection.InsertOne(entity);
            return entity;
        }

        public virtual async Task AddAsync(T entity, CancellationToken cancellationToken)
        {
            await Collection.InsertOneAsync(entity, cancellationToken);
        }

        public virtual bool Delete(string id)
        {
            var filter = Builders<T>.Filter.Eq(e => e.GetType().GetProperty("Id").GetValue(e), id);
            var result = Collection.DeleteOne(filter);

            return result.IsAcknowledged && result.DeletedCount > 0;
        }

        public virtual async Task<bool> DeleteAsync(string id, CancellationToken cancellationToken)
        {
            var result = await Collection.DeleteOneAsync(e => e.Id == id);
            return result.IsAcknowledged && result.DeletedCount > 0;
        }

        public virtual T Get(string id)
        {
            var filter = Builders<T>.Filter.Eq(e => e.GetType().GetProperty("Id").GetValue(e), id);
            return Collection.Find(filter).FirstOrDefault();
        }

        public virtual IQueryable<T> GetAll(bool noTracking = false)
        {
            return Collection.AsQueryable();
        }

        public virtual async Task<List<T>> GetAllAsync(CancellationToken cancellationToken, bool asNoTracking = false)
        {
            var filter = Builders<T>.Filter.Empty;
            return await Collection.Find(filter).ToListAsync();
        }

        public virtual async Task<T> GetAsync(string id, CancellationToken cancellationToken)
        {
            //var filter = Builders<T>.Filter.Eq(e => e.GetType().GetProperty("Id").GetValue(e), id);
            var filter = Builders<T>.Filter.Eq(e => e.Id, id);

            return await Collection.Find(filter).FirstOrDefaultAsync();
        }

        public virtual bool Update(T entity)
        {
            var filter = Builders<T>.Filter.Eq(e => e.GetType().GetProperty("Id").GetValue(e), entity.GetType().GetProperty("Id").GetValue(entity));
            var result = Collection.ReplaceOne(filter, entity);

            return result.IsAcknowledged && result.ModifiedCount > 0;
        }

        public virtual async Task<T> UpdateAsync(T entity, CancellationToken cancellationToken)
        {
            //var filter = Builders<T>.Filter.Eq(e => e.GetType().GetProperty("Id").GetValue(e), entity.GetType().GetProperty("Id").GetValue(entity));
            //await Collection.ReplaceOneAsync(filter, entity);

            throw new NotImplementedException();
        }
    }
}