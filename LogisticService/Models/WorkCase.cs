using Google.Maps.Routing.V2;
using LogisticService.Data;


namespace LogisticService.Models
{
    public class WorkCase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Waypoint Origin { get; set; }
        public Waypoint Destination { get; set; }
        public RouteTravelMode TravelMode { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime Deadline { get; set; }
    }
}
