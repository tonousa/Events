using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State
{
    public partial class Default : System.Web.UI.Page
    {
        private int counter;
        private string user;

        protected void Page_Load(object sender, EventArgs e)
        {
            //user = Request.Form["requestedUser"] ?? "Joe";
            //counter = (int)(ViewState["counter"] ?? 0);
            //ViewState["counter"] = ++counter;
            HttpCookie incomingCookie = Request.Cookies["counter"];
            counter = incomingCookie == null ? 0 : int.Parse(incomingCookie.Value);
            counter++;
            Response.Cookies.Add(new HttpCookie("counter", counter.ToString()));
        }

        protected int GetCounter()
        {
            return counter;
        }

        protected int GetUserCounter()
        {
            //Application.Lock();
            //int result = (int)(Application["counter"] ?? 0);
            //Application["counter"] = ++result;
            //Application.UnLock();
            //return result;

            ProfileBase profile = ProfileBase.Create(user);
            int counter = (int)profile["counter"];
            profile["counter"] = ++counter;
            profile.Save();
            return counter;
        }

        protected int GetSessionCounter()
        {
            int counter = (int)(Session["counter"] ?? 0);
            Session["counter"] = ++counter;
            return counter;
        }
    }
}