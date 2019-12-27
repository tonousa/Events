using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithControls
{
    public partial class RepeaterButtons : System.Web.UI.Page
    {
        private string[] colors = { "Red", "Green", "Blue" };

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<System.String> GetButtonDetails()
        {
            return colors;
        }

        public void HandleClick(object source, RepeaterCommandEventArgs e)
        {
            selectedValue.InnerHtml = string.Format("The {0} button was clicked",
                ((Button)e.CommandSource).Text);
        }
    }
}