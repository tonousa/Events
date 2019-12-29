using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithForms
{
    public partial class MultiForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST" && Request.Form["button2"] != null)
            {
                result.InnerHtml = string.Format("The city is: {0}",
                    Request.Form["city"]);
                city.Value = Request.Form["city"];
            }
            else if (Request.Form["button1"] != null)
            {
                result.InnerHtml = color.Text;
            }
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            //result.InnerHtml = color.Text;
        }
    }
}