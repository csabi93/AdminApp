using System.Web;
using System.Web.Optimization;

namespace Maintenanceapp2
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                     "~/Scripts/jquery.unobtrusive*",
                     "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                   "~/Scripts/kendo/2017.2.621/jquery.min.js",
                  "~/Scripts/kendo/2017.2.621/jszip.min.js",
                   "~/Scripts/kendo/2017.2.621/kendo.all.min.js",
                   "~/Scripts/kendo/2017.2.621/kendo.aspnetmvc.min.js",
                   "~/Scripts/kendo.modernizr.custom.js",
                   "~/Scripts/kendo/2017.2.621/cultures/kendo.culture.hu.min.js",
                   "~/Scripts/kendo/2017.2.621/cultures/kendo.culture.hu-HU.min.js"
                     ));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                  "~/Scripts/kendo/2017.2.621/jquery.min.js",
               "~/Scripts/kendo/2017.2.621/jszip.min.js",
                "~/Scripts/kendo/2017.2.621/kendo.all.min.js",
                "~/Scripts/kendo/2017.2.621/kendo.aspnetmvc.min.js",
                "~/Scripts/kendo.modernizr.custom.js",
                "~/Scripts/kendo/2017.2.621/messages/kendo.messages.hu-HU.min.js",
                    "~/Scripts/kendo/2017.2.621/cultures/kendo.culture.hu-HU.min.js",
                    "~/Scripts/typings/appScriptsJS/inputvalidation.js"
                  ));
            
            bundles.Add(new StyleBundle("~/Content/kendo/2017.2.621/css").Include(
                 "~/Content/kendo/2017.2.621/kendo.common.min.css",
                "~/Content/kendo/2017.2.621/kendo.mobile.all.min.css",
                  "~/Content/kendo/2017.2.621/kendo.dataviz.min.css",
                    "~/Content/kendo/2017.2.621/kendo.default.min.css",
                     "~/Content/kendo/2017.2.621/kendo.dataviz.default.min.css"
                  ));


        }
    }
}
