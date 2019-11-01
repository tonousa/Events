﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ErrorHandling
{
    public class ErrorModule : IHttpModule
    {
        public void Init(HttpApplication app)
        {
            app.Error += (src, args) => HandleRequest(app);
            app.EndRequest += (src, args) => HandleRequest(app);
        }

        public void HandleRequest(HttpApplication app)
        {
            if (app.Context.AllErrors != null)
            {
                app.Response.ClearHeaders();
                app.Response.ClearContent();
                app.Response.StatusCode = 200;
                app.Server.Execute("/MultipleErrors.aspx");
                app.Context.ClearError();
            }
        }

        public void Dispose()
        {
            //
        }
    }
}