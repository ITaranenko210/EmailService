using Google.Maps.Routing.V2;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
namespace LogisticService.Data.WorkCases
{
    public class WorkCaseRouteAdapter 
    {
        public Waypoint Origin { get; set; }
        public Timestamp ArrivalTime { get; set; }
        public bool ComputeAlternativeRoutes { get; set; }
        public Timestamp DepartureTime { get; set; }
        public Waypoint Destination { get; set; }
        public RepeatedField<ComputeRoutesRequest.Types.ExtraComputation> ExtraComputations { get; set; }
        public List<Waypoint> Intermediates { get; set; }
        public string LanguageCode { get; set; }
        public bool OptimizeWaypointOrder { get; set; }
        public string RegionCode { get; set; }
        public RepeatedField<ComputeRoutesRequest.Types.ReferenceRoute> RequestedReferenceRoutes { get; }
        public RouteModifiers RouteModifiers { get; set; }
        public RoutingPreference RoutingPreference { get; set; }
        public TrafficModel TrafficModel { get; set; }
        public TransitPreferences TransitPreferences { get; set; }
        public RouteTravelMode TravelMode { get; set; }
        public Units Units { get; set; }
    }
}
