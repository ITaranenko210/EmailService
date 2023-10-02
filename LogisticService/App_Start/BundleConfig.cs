using System.Web.Optimization;

namespace LogisticService.App_Start
{
    public class BundleConfig
    {
       
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/lib/jquery").Include(
                "~/lib/jquery/jquery-{version}.js",
                "~/lib/jquery/jquery.*",
                "~/lib/jquery/jquery-ui-{version}.js")
            );

            bundles.Add(new ScriptBundle("~/lib/knockout").Include(
                    "~/lib/knockout/knockout-{version}.js",
                    "~/lib/knockout/knockout-deferred-updates.js")
            );
            bundles.Add(new ScriptBundle("~/js/maps_launch").Include("~/js/maps_launch.js"));
            
        }
        
    }
}
