using System;
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
            if (app.Request.FilePath == "/Test.aspx")
            {
                app.Server.Transfer("/Content/RequestReporter.aspx");
            }

            WriteMsg("URL requested {0}", app.Request.RawUrl);
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