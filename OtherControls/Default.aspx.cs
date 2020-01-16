using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtherControls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HandleClick(object src, EventArgs args)
        {
            string controlID = (string)Session["myControl"];
            if (controlID != null && ((Control)src).ID == controlID)
            {
                result.InnerText = (int.Parse(result.InnerText) + 1).ToString();
            }
            Session["myControl"] = ((Control)src).ID;
        }
    }
}