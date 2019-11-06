using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PathsAndUrls
{
    public class PathModule : IHttpModule
    {
        private static readonly string[] extensions = { ".aspx", ".ashx" };

        public void Init(HttpApplication app)
        {
            app.BeginRequest += (src, args) => HandleRequest(app);
        }

        public void HandleRequest(HttpApplication app)
        {
            if (app.Request.CurrentExecutionFilePathExtension == String.Empty)
            {
                string target = null;
                string vpath = app.Request.CurrentExecutionFilePath;

                if (vpath == "/")
                {
                    target = "/Default.aspx";
                }
                else
                {
                    foreach (string ext in extensions)
                    {
                        if (File.Exists(app.Request.MapPath(vpath + ext)))
                        {
                            target = vpath + ext;
                            break;
                        }
                    }
                }

                if (target != null)
                {
                    app.Context.RewritePath(target);
                }
            }
        }

        public void Dispose()
        {

        }
    }
}