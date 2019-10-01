using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RequestControl
{
    public partial class SxSView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string html = (string)Context.Items["htmlResponse"];
            string src = (string)Context.Items["sourceResponse"];

            htmlPanel.InnerHtml = html;
            srcPanel.InnerHtml = src;
        }
    }
}