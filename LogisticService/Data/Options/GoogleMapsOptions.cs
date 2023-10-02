using System.ComponentModel.DataAnnotations;

namespace LogisticService.Data.Options
{
    interface IGoogleMapsOptions
    {

    }
    public class GoogleMapsOptions: IGoogleMapsOptions
    {
    
        public const string Position = "GoogleMapsSettings";
        public string? APIKey { get; set; } = String.Empty;
        public string? APIKeySyntax { get; set; } = String.Empty;
        public string? BaseAddress { get; set; } = String.Empty;
        public string? ComputeRoutes { get; set;  } = String.Empty;
        public string? ComputeRouteMatrix { get; set; } = String.Empty; 
        public string? GetCurrentLocation { get; set; } = String.Empty;
    }
}
