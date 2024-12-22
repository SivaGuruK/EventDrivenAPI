var builder = WebApplication.CreateBuilder(args);

var mongoConfig = new MongoDBConfig("mongodb://localhost:27017", "EventDrivenDB");
builder.Services.AddSingleton(mongoConfig);

builder.Services.AddScoped<EventRepository>();
builder.Services.AddScoped<EventService>();

builder.Services.AddControllers();

var app = builder.Build();

// app.UseMiddleware<AuthenticationMiddleware>();
app.MapControllers();

app.Run();
