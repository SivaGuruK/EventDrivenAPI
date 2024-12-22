using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Topic
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("Name")]
    public string Name { get; set; }

    [BsonElement("Subscribers")]
    public List<string> Subscribers { get; set; }
}
