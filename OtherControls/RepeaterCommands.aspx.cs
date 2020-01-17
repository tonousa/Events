using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtherControls
{
    public partial class RepeaterCommands : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rep.ItemCommand += (src, args) => {
                if (args.CommandName == "Select")
                {
                    selectedValue.InnerText = args.CommandArgument.ToString();
                }
            };
        }

        public IEnumerable<System.String> rep_GetData()
        {
            return new string[] { "Red", "Green", "Blue", "Black", "White" };
        }
    }
}