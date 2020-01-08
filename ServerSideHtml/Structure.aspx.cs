using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSideHtml
{
    public partial class Structure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Header.Description = "simple example";
            Header.Title = "Structure elements";
            Header.Keywords = "ASP.NET, HTML";
        }
    }
}