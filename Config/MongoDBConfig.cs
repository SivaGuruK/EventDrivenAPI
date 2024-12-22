using MongoDB.Driver;

public class MongoDBConfig
{
    private readonly IMongoDatabase _database;

    public MongoDBConfig(string connectionString, string databaseName)
    {
        var client = new MongoClient(connectionString);
        _database = client.GetDatabase(databaseName);
    }

    public IMongoCollection<T> GetCollection<T>(string collectionName) =>
        _database.GetCollection<T>(collectionName);
}
