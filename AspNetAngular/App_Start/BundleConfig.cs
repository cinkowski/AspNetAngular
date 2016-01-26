using System.Web;
using System.Web.Optimization;

namespace AspNetAngular
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/Angular")
                .Include("~/Scripts/angular.min.js")
                .Include("~/Scripts/angular-route.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/AspNetAngular")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                .IncludeDirectory("~/Scripts/Factories", "*.js")
                .Include("~/Scripts/AspNetAngular.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
