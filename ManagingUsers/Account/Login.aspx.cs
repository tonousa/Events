using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace ManagingUsers.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string user = Request["user"];
                string pass = Request["pass"];
                string action = Request["action"];
                //if (action == "login" && user == "Joe" && pass == "secret")
                if (action == "login" && Membership.ValidateUser(user, pass))
                    {
                        FormsAuthentication.RedirectFromLoginPage(user, false);
                }
                else
                {
                    //FormsAuthentication.SignOut();
                    //Response.Redirect(Request.Path);
                    message.Style["visibility"] = "visible";
                }
            }
            else if (Request.IsAuthenticated)
            {
                Response.StatusCode = 403;
                Response.SuppressContent = true;
                Context.ApplicationInstance.CompleteRequest();
            }
        }

        protected bool GetRequestStatus()
        {
            return Request.IsAuthenticated;
        }
        
        protected string GetUser()
        {
            return Context.User.Identity.Name;
        }
    }
}