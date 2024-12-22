using MongoDB.Driver;

public class EventRepository
{
    private readonly IMongoCollection<Event> _eventCollection;

    public EventRepository(MongoDBConfig config)
    {
        _eventCollection = config.GetCollection<Event>("Events");
    }

    public async Task CreateEventAsync(Event eventData) =>
        await _eventCollection.InsertOneAsync(eventData);

    public async Task<List<Event>> GetEventsAsync(string topic) =>
        await _eventCollection.Find(e => e.Topic == topic).ToListAsync();
}
