using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ErrorHandling
{
    public partial class NotFoundShared : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            requestedUrl.InnerText = Request["aspxerrorpath"] ?? Request.RawUrl;
            errorSrc.InnerText = Request["aspxerrorpath"] == null ? "IIS" : "ASP.NET";
        }
    }
}