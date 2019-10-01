using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace Caching
{
    public class RequestEventMapModule : IHttpModule
    {
        public event EventHandler BeginRequest;

        public void Init(HttpApplication app)
        {
            app.BeginRequest += (src, args) =>
            {
                if (BeginRequest != null)
                {
                    BeginRequest(this, EventArgs.Empty);
                };
            };
        }

        public void Dispose()
        {

        }
    }

    public class RequestCountDependency : CacheDependency
    {
        private int RequestCount;
        private int RequestLimit;

        public RequestCountDependency(int limit)
        {
            RequestLimit = limit;
            RequestCount = 0;
            ConfigureEventHandler(true);
            FinishInit();
        }

        private void ConfigureEventHandler(bool attach)
        {
            if (HttpContext.Current != null)
            {
                RequestEventMapModule module =
                    HttpContext.Current.ApplicationInstance
                    .Modules["RequestEventMap"]
                    as RequestEventMapModule;
                if (module != null)
                {
                    if (attach)
                    {
                        module.BeginRequest += HandleEvent;
                    }
                    else
                    {
                        module.BeginRequest -= HandleEvent; 
                    }
                }
            }
        }

        private void HandleEvent(object src, EventArgs args)
        {
            if (++RequestCount > RequestLimit)
            {
                NotifyDependencyChanged(this, EventArgs.Empty);
            }
        }

        protected override void DependencyDispose()
        {
            ConfigureEventHandler(false);
            base.DependencyDispose();
        }
    }
}