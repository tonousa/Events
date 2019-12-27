using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithControls
{
    public partial class HtmlRepeaterButtons : System.Web.UI.Page
    {
        private string[] colors = { "Red", "Green", "Blue" };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack && Request.Form["action"] != null)
            {
                selectedValue.InnerText = string.Format("The {0} button was clicked",
                    Request.Form["action"]);
            }
        }

        public IEnumerable<string> GetButtonDetails()
        {
            return colors;
        }
    }
}