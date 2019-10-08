using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caching
{
    public partial class CachedForm : System.Web.UI.Page
    {
        private double total = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                total = double.Parse(quantity.Value) * double.Parse(price.Value);
            }
        }

        protected string GetTotal()
        {
            return total == 0 ? "" : total.ToString("C");
        }

        protected string GetTimeStamp()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}