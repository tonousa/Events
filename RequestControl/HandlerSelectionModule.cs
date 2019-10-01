using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RequestControl
{
    public class HandlerSelectionModule : IHttpModule
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Init(HttpApplication app)
        {
            app.PostResolveRequestCache += (src, args) =>
            {
                if (app.Request.RequestType == "POST")
                {
                    switch (app.Request.Form["choice"])
                    {
                        case "remaphandler":
                            app.Context.RemapHandler(new CurrentTimeHandler());
                            break;
                        case "execute":
                            string[] paths = { "default.aspx", "secondpage.aspx" };
                            foreach (string path in paths)
                            {
                                app.Response.Write(string.Format(
                                    "<div>this is the {0}response</div>", path));
                                app.Server.Execute(path);
                            }
                            app.CompleteRequest();
                            break;
                    }
                }
            };
        }
    }
}