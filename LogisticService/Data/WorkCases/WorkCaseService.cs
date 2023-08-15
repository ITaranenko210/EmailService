using Elasticsearch.Net;
using Google.Api.Gax.Grpc;
using Google.Maps.Routing.V2;
using Google.Protobuf.Collections;
using Google.Type;
using LogisticService.Models;

namespace LogisticService.Data.WorkCases
{
    interface IWorkCaseService
    {
        ComputeRoutesResponse ComputeRoute(WorkCase workCase);
    }
    public class WorkCaseService : IWorkCaseService
    {
        public ComputeRoutesResponse ComputeRoute(WorkCase workCase)
        {
            using (var httpClient = new HttpClient())
            {
                var postData = new PostData
                {
                    Name = "John Doe",
                    Age = 30,
                    Address = "123 Main St"
                };
            }

                RoutesClient client = RoutesClient.Create();
            CallSettings callSettings = CallSettings.FromHeader("X-Goog-FieldMask", "*");
            ComputeRoutesRequest request = new ComputeRoutesRequest
            {
                Origin = workCase.Origin,
                Destination = workCase.Destination,
                TravelMode = workCase.TravelMode,
                //Intermediates - ? I can't use intermediates in gRPC request cause it get prop, Schould change it in http request where I can use it. 
                //{
                //    Location = new Location { LatLng = new LatLng { Latitude = 37.419734, Longitude = -122.0827784 } }
                //},
                //Destination = new Waypoint
                //{
                //    Location = new Location { LatLng = new LatLng { Latitude = 37.417670, Longitude = -122.079595 } }
                //},
                //TravelMode = RouteTravelMode.Drive,
                //RoutingPreference = RoutingPreference.TrafficAware
            };
            return client.ComputeRoutes(request, callSettings);
           
        }
    }
}
