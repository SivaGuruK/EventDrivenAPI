using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Event
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("Topic")]
    public string Topic { get; set; }

    [BsonElement("Payload")]
    public string Payload { get; set; }

    [BsonElement("Timestamp")]
    public DateTime Timestamp { get; set; }
}
