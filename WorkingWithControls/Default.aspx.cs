using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithControls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int countVal = (int)(Session["counter"] ?? 0);
            if (IsPostBack)
            {
                Session["counter"] = ++countVal;
            }
            counter.InnerText = countVal.ToString();
        }
    }
}