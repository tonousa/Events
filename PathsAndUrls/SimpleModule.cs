﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PathsAndUrls
{
    public class SimpleModule : IHttpModule
    {
        public void Init(HttpApplication app)
        {
            app.BeginRequest += (src, args) => ProcessRequest(app);
        }

        private void ProcessRequest(HttpApplication app)
        {
            //if (app.Request.FilePath == "/Test.aspx")
            //{
            //    app.Server.Transfer("/Content/RequestReporter.aspx");
            //}

            if (app.Request.Path == "/accounts")
            {
                int functionValue;
                if (int.TryParse(app.Request.Form["function"], out functionValue))
                {
                    if (functionValue < 100)
                    {
                        app.Context.RewritePath("/Default.aspx");
                    }
                    else
                    {
                        app.Context.RewritePath("/Content/RequestReporter.aspx");
                    }
                }
            }

            WriteMsg("URL requested: {0} {1}", app.Request.RawUrl, app.Request.FilePath);
        }

        private void WriteMsg(string formatString, params object[] vals)
        {
            Debug.WriteLine(formatString, vals);
        }

        public void Dispose()
        {

        }
    }
}