using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                int firstVal = int.Parse(Request.Form["firstNumber"]);
                int secoundVal = int.Parse(Request.Form["secondNumber"]);
                result.InnerText = (firstVal + secoundVal).ToString();
            }
        }
    }
}