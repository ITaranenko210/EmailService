using System.ComponentModel.DataAnnotations;

namespace LogisticService.Data.Options
{
    interface IGoogleMapsOptions
    {

    }
    public class GoogleMapsOptions: IGoogleMapsOptions
    {
    
        public const string Position = "GoogleMapsSettings";
        public string? APIKey { get;  }
        public string? APIKeySyntax { get;  }
        public string? BaseAddress { get;  }
        public string? ComputeRoutes { get;  }
        public string? ComputeRouteMatrix { get; }
        public string? GetCurrentLocation { get; }
    }
}
