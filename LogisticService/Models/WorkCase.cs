using Google.Maps.Routing.V2;
using LogisticService.Data;
using System.Collections.Generic;

namespace LogisticService.Models
{
    public class WorkCase
    {
        public WorkCase()
        {
            WorkCaseLocations = new HashSet<WorkCaseLocation>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        //public ICollection<WorkCaseLocation> Origin { get; set; }
        public ICollection<WorkCaseLocation> WorkCaseLocations { get; set; }
        public RouteTravelMode TravelMode { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime Deadline { get; set; }
    }
}
