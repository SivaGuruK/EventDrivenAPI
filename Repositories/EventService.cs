public class EventService
{
    private readonly EventRepository _eventRepository;

    public EventService(EventRepository eventRepository)
    {
        _eventRepository = eventRepository;
    }

    public async Task PublishEventAsync(EventDTO eventDTO)
    {
        var eventData = new Event
        {
            Topic = eventDTO.Topic,
            Payload = eventDTO.Payload,
            Timestamp = DateTime.UtcNow
        };
        await _eventRepository.CreateEventAsync(eventData);
    }

    public async Task<List<Event>> GetEventsAsync(string topic) =>
        await _eventRepository.GetEventsAsync(topic);
}
