using Google.Maps.Routing.V2;
using Microsoft.AspNetCore.Identity;

namespace LogisticService.Data.ApplicationUsers
{
    public class ApplicationUser : IdentityUser
    {
        public RouteTravelMode TravelMode;
    }
}
