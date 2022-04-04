using System.Web;
using System.Web.Optimization;

namespace DemoMVCWebsite
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/JQuery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/JQuery/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/Modernizer/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/Bootstrap/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Bootstrap/bootstrap.css",
                      "~/Content/Site/Site.css"));

            bundles.Add(new ScriptBundle("~/bundles/signin").Include(
                        "~/Scripts/SignIn/signin.js"));

            bundles.Add(new StyleBundle("~/Content/createnewaccount").Include(
                      "~/Content/CreateNewAccount/createnewaccount.css"));

            bundles.Add(new ScriptBundle("~/bundles/chart").Include(
                        "~/Scripts/Charts/fusioncharts.js",
                        "~/Scripts/Charts/fusioncharts.charts.js",
                        "~/Scripts/Themes/fusioncharts.theme.zune.js",
                        "~/Scripts/Charts/chart.js"
                        //"~/Scripts/Themes/fusioncharts.theme.ocean.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/createnewaccount").Include(
                        "~/Scripts/CreateNewAccount/createnewaccount.js"));

            bundles.Add(new StyleBundle("~/Content/signin").Include(
                      "~/Content/SignIn/SignIn.css"));

            bundles.Add(new ScriptBundle("~/bundles/userrecord").Include(
                        "~/Scripts/UserRecord/userrecord.js",
                        "~/Scripts/UserRecord/managepager.js"
                        ));
            bundles.Add(new StyleBundle("~/Content/userrecord").Include(
                    "~/Content/UserRecord/userrecord.css"
                ));
        }
    }
}
