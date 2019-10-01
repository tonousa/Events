using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace RequestControl
{
    public class SxSHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            string reqFilePath = context.Request.FilePath;
            reqFilePath = reqFilePath.Substring(0, reqFilePath.LastIndexOf("."));

            StringWriter htmlResponseString = new StringWriter();
            StringWriter srcResponseString = new StringWriter();

            context.Server.Execute(reqFilePath, htmlResponseString);
            context.Server.Execute(new SourceViewHandler(), srcResponseString, true);

            context.Items["htmlResponse"] = htmlResponseString.ToString();
            context.Items["sourceResponse"] = srcResponseString.ToString();

            context.Server.Execute("/SxSView.aspx");
            context.ApplicationInstance.CompleteRequest();
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}