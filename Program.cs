using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/getwaypoints", () => {
    var waypoints = new List<Waypoint>();

    waypoints.Add(new Waypoint("Waypoint 1", 49.81693887423546f, 19.013345700074744f));
    waypoints.Add(new Waypoint("Waypoint 2", 49.81813459091276f, 19.01493052434592f));
    waypoints.Add(new Waypoint("Waypoint 3", 49.81318871942243f, 19.01085903690916f));

    return JsonSerializer.Serialize(waypoints);
});

app.Run();
