using Elasticsearch.Net;
using Google.Api.Gax.Grpc;
using Google.Maps.Routing.V2;
using Google.Protobuf.Collections;
using Google.Type;
using LogisticService.Data.GoogleMaps;
using LogisticService.Data.Options;
using LogisticService.Models;
using Microsoft.Extensions.Options;
using System.Text;
using System.Text.Json;

namespace LogisticService.Data.WorkCases
{
    interface IWorkCaseService
    {
        ComputeRouteResp ComputeRoute(WorkCase workCase);
    }
    public class WorkCaseService : IWorkCaseService
    {
        private readonly GoogleMapsOptions _options;

        public WorkCaseService(IOptions<GoogleMapsOptions> options)
        {
            _options = options.Value;
        }
        public ComputeRouteResp ComputeRoute(WorkCase workCase)
        {
            using (var httpClient = new HttpClient())
            {
               var Address = new Uri(_options.BaseAddress + _options.ComputeRoutes + _options.APIKeySyntax + _options.APIKey);

                WorkCaseRouteAdapter request = new WorkCaseRouteAdapter()
                {
                    Origin = workCase.Origin,
                    Destination = workCase.Destination,
                    Intermediates = new List<Waypoint> (){ }
                };
                var json = System.Text.Json.JsonSerializer.Serialize(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var result = httpClient.PostAsync(Address, content).Result;
                if (result.IsSuccessStatusCode)
                {
                    var responseContent = result.Content.ReadAsStringAsync().Result;

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    return System.Text.Json.JsonSerializer.Deserialize<ComputeRouteResp>(responseContent, options);
                   

                }
                else
                {
                    return new ComputeRouteResp();
                }
            }

               
           
        }
    }
}
