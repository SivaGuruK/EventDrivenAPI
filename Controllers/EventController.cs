using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/events")]
public class EventController : ControllerBase
{
    private readonly EventService _eventService;

    public EventController(EventService eventService)
    {
        _eventService = eventService;
    }

    [HttpPost("publish")]
    public async Task<IActionResult> PublishEvent([FromBody] EventDTO eventDTO)
    {
        await _eventService.PublishEventAsync(eventDTO);
        return Ok("Event published successfully!");
    }

    [HttpGet]
    public async Task<IActionResult> GetEvents([FromQuery] string topic)
    {
        var events = await _eventService.GetEventsAsync(topic);
        return Ok(events);
    }
}
