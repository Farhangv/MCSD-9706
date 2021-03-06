﻿using System.Web;
using System.Web.Optimization;

namespace PropMan
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap-rtl.js"));

            bundles.Add(new ScriptBundle("~/bundles/farsiToolkit").Include(
                      "~/Scripts/farsiInput.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-rtl.css",
                      "~/Content/bootstrap-theme-rtl.css",
                      "~/fonts/vazir.css",
                      "~/Content/font-awesome.css",
                      "~/Content/site.css"));
        }
    }
}
