using System;
using System.Web;

namespace CommonModules
{
    public class TimerEventArgs : EventArgs
    {
        public double Duration { get; set; }
    }

    public class TimerModule : IHttpModule
    {
        /// <summary>
        /// You will need to configure this module in the Web.config file of your
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members

        private DateTime startTime;
        public event EventHandler<TimerEventArgs> RequestTimed;

        public void Dispose()
        {
            //clean-up code here.
        }

        public void Init(HttpApplication app)
        {
            // Below is an example of how you can handle LogRequest event and provide 
            // custom logging implementation for it
            app.BeginRequest += HandleEvent;
            app.EndRequest += HandleEvent;
        }

        private void HandleEvent(object src, EventArgs args)
        {
            HttpApplication app = src as HttpApplication;
            switch (app.Context.CurrentNotification)
            {
                case RequestNotification.BeginRequest:
                    startTime = app.Context.Timestamp;
                    break;
                case RequestNotification.EndRequest:
                    double elapsed = DateTime.Now.Subtract(startTime).TotalMilliseconds;
                    System.Diagnostics.Debug.WriteLine(
                        string.Format("Duration: {0} {1}ms", 
                        app.Request.RawUrl, elapsed));
                    if (RequestTimed != null)
                    {
                        RequestTimed(this, new TimerEventArgs { Duration = elapsed });
                    }
                    break;
            }
        }

        #endregion

    }
}
