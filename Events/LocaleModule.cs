using System;
using System.Globalization;
using System.Threading;
using System.Web;

namespace Events
{
    public class LocaleModule : IHttpModule
    {
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
            ////context.LogRequest += new EventHandler(OnLogRequest);
            app.BeginRequest += HandleEvent;
        }

        private void HandleEvent(object src, EventArgs args)
        {
            string[] langs = ((HttpApplication)src).Request.UserLanguages;
            if (langs != null && langs.Length > 0 && langs[0] != null)
            {
                try
                {
                    //Thread.CurrentThread.CurrentCulture = new CultureInfo(langs[0]);
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
                }
                catch (Exception)
                {

                    //throw;
                }
            }
        }

        #endregion

        public void OnLogRequest(Object source, EventArgs e)
        {
            //custom logging logic can go here
        }
    }
}
