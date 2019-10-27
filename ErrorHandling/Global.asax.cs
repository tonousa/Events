using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ErrorHandling
{
    public enum Failure
    {
        None,
        Database,
        FileSystem,
        Network
    }

    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Failure failReason = CheckForRootCause();
            if (failReason != Failure.None)
            {
                Response.ClearHeaders();
                Response.ClearContent();
                Response.StatusCode = 200;

                Server.Execute(string.Format(
                    "/ComponentError.aspx?errorSource={0}&errorType={1}",
                    "The " + failReason.ToString().ToLower(),
                    Context.Error.GetType()));
                Context.ClearError();

                //Response.Redirect(string.Format(
                //    "/ComponentError.aspx?errorSource={0}&errorType={1}",
                //    "The " + failReason.ToString().ToLower(),
                //    Context.Error.GetType()));
            }
            //Debug.WriteLine(string.Format("Failure {0}, Exception type {1}",
            //    failReason, Context.Error.GetType()));
            Debug.WriteLine("server execute!!!");
        }

        private Failure CheckForRootCause()
        {
            //get results of latest health checks
            Array values = Enum.GetValues(typeof(Failure));
            return (Failure)values.GetValue(new Random().Next(values.Length));
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}