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
            ControlUtils.EnumerateControls(this, true);
        }

        protected void ButtonClick(object src, EventArgs args)
        {
            int count = (int)(Session["ui_counter"] ?? 0);
            Session["ui_counter"] = ++count;
            uiLabel.Text = count.ToString();
        }
    }
}