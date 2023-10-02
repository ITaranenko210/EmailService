using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace LogisticService.Data.Options
{
    public interface ITestOptions
    {
        GoogleMapsOptions GetOptions();
    }
    public class TestOptions : ITestOptions
    {
        private readonly GoogleMapsOptions _googleMapsOptions;

        public TestOptions(IOptions<GoogleMapsOptions> options)
        {
            _googleMapsOptions = options.Value;
        }

        public GoogleMapsOptions GetOptions()
        {
            return _googleMapsOptions;
        }
           
            
    }
}
