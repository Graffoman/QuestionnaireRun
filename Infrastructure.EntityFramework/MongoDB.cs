using MongoDB.Driver;

namespace Infrastructure.DataAcess
{
    public class MongoDB<T>
    {
        public IMongoCollection<T> Collection;

        public MongoDB()
        {
            MongoClient client = new("mongodb://admin:admin@84.201.158.212:27017/?authSource=admin");
            IMongoDatabase database = client.GetDatabase("MongoDB");
        

            string collectionName = typeof(T).Name.ToLower() + "s";

            Collection = database.GetCollection<T>(collectionName);
        }
    }
}
