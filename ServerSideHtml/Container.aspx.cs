using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ServerSideHtml
{
    public partial class Container : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProcessContainerControl(outerDiv);
        }

        protected void ProcessContainerControl(HtmlContainerControl c)
        {
            bool isLiteral = IsLiteralContent(c);
            Debug.WriteLine("ID: {0} Literal: {1}, InnerText: {2}",
                c.ID, isLiteral, isLiteral ? c.InnerText.Trim() : "N/A");

            foreach (Control child in c.Controls)
            {
                if (child is HtmlContainerControl)
                {
                    ProcessContainerControl(child as HtmlContainerControl);
                }
            }
        }

        protected bool IsLiteralContent(Control c)
        {
            return c.Controls != null && c.Controls.Count == 1
                && c.Controls[0] is LiteralControl;
        }
    }
}