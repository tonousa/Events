using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagingUsers
{
    public class AuthModule : IHttpModule
    {
        public void Init(HttpApplication app)
        {
            app.PostAuthenticateRequest += (src, args) =>
            {
                if (app.Request.Path == "/Admin/Open.aspx")
                {
                    app.Context.SkipAuthorization = true;
                }
            };
        }

        public void Dispose()
        {
            //
        }
    }
}