var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.SetMinimumLevel(LogLevel.Information);
builder.Logging.AddConsole();
var app = builder.Build();
app.MapGet("/test400", () => { throw new BadHttpRequestException("TEST"); });
app.Run();