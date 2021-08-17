using System.Web;
using System.Web.Optimization;

namespace Fizzbuzz.MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/FizzStyles.css",
                      "~/Content/PagedList.css"));
        }
    }
}
