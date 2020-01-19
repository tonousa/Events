﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ClientDev
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            Bundle jquery = new ScriptBundle("~/bundle/jquery");
            jquery.CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.2.min.js";
            jquery.Include("~/scripts/jquery-{version}.js");

            Bundle jqueryui = new ScriptBundle("~/bundle/jqueryui");
            jqueryui.CdnPath = "http://ajax.aspnetcdn.com/ajax/jquery.ui/1.10.2/jquery-ui.min.js";
            jqueryui.Include("~/Scripts/jquery-ui-{version}.js");

            Bundle basicStyles = new StyleBundle("~/bundle/basicCSS")
                .Include("~/MainStyles.css", "~/ErrorStyles.css");

            Bundle jqueryUIStyles = new StyleBundle("~/Content/themes/base/jqueryUICSS")
                .IncludeDirectory("~/content/themes/base", "*.css");

            bundles.UseCdn = true;

            bundles.Add(jquery);
            bundles.Add(jqueryui);
            bundles.Add(basicStyles);
            bundles.Add(jqueryUIStyles);
        }
    }
}