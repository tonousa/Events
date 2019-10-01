using System;
using System.Web;

namespace Handlers
{
    public class TotalDurationModule : IHttpModule
    {
        private double totalTime = 0;
        private int requestCount = 0;

        /// <summary>
        /// You will need to configure this module in the Web.config file of your
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members

        public void Dispose()
        {
            //clean-up code here.
        }

        public void Init(HttpApplication app)
        {
            // Below is an example of how you can handle LogRequest event and provide 
            // custom logging implementation for it
            //context.LogRequest += new EventHandler(OnLogRequest);
            app.PreRequestHandlerExecute += HandleEvent;
            app.PostRequestHandlerExecute += HandleEvent;
        }

        private void HandleEvent(object src, EventArgs args)
        {
            HttpContext context = ((HttpApplication)src).Context;
            if (!context.IsPostNotification)
            // is Pre handler execute
            {
                context.Items["total_time"] = totalTime;
            }
            else if (context.Handler is IRequiresDurationData)
            {
                totalTime = (double)context.Items["total_time"];
                requestCount++;
                System.Diagnostics.Debug.WriteLine(
                    string.Format("Total duration is: {0}ms for {1} requests",
                    totalTime, requestCount));
            }
        }

        #endregion

        public void OnLogRequest(Object source, EventArgs e)
        {
            //custom logging logic can go here
        }
    }
}
