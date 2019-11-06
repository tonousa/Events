using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PathsAndUrls
{
    public class ExtensionlessHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<p>Extensionless Handler</p>");
            string vpath = context.Request.Path;
            if (vpath == "/")
            {
                context.Server.Transfer("/Default.aspx");
            }
            else if (File.Exists(context.Request.MapPath(vpath + ".aspx")))
            {
                context.Server.Transfer(vpath + ".aspx");
            }
            else
            {
                context.Response.StatusCode = 404;
                context.ApplicationInstance.CompleteRequest();
            }
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}