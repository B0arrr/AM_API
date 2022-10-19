class Waypoint
{
    public string Name { get; set; }
    public float Latitude { get; set; }
    public float Longitude { get; set; }
    public Waypoint(string name, float latitude, float longitude)
    {
        Name = name;
        Latitude = latitude;
        Longitude = longitude;
    }
}