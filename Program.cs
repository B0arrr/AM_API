using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "Origins",
        policy =>
        {
            policy.WithOrigins("*");
        });
});
var app = builder.Build();

app.MapGet("/getwaypoints", () => {
    var waypoints = new List<Waypoint>();

    waypoints.Add(new Waypoint
    {
        Name = "Waypoint 1",
        Latitude = 49.81693887423546f, 
        Longitude = 19.013345700074744f,
        Task = "Zrób 10 pajacyków"
    });
    waypoints.Add(new Waypoint
    {
        Name = "Waypoint 2",
        Latitude = 49.81813459091276f, 
        Longitude = 19.01493052434592f,
        Task = "Zrób 10 brzuszków"
    });
    waypoints.Add(new Waypoint
    {
        Name = "Waypoint 3",
        Latitude = 49.81318871942243f, 
        Longitude = 19.01085903690916f,
        Task = "Zrób 10 pajacyków"
    });

    return JsonSerializer.Serialize(waypoints);
});

app.UseCors();

app.Run();
