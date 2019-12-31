using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controls.Custom
{
    public partial class BasicCalc : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                int firstVal = int.Parse(GetFormValue("firstNumber"));
                int secondVal = int.Parse(GetFormValue("secondNumber"));
                result.InnerText = (firstVal + secondVal).ToString();
            }
        }

        private string GetFormValue(string name)
        {
            return Request.Form[GetId(name)];
        }

        protected string GetId(string name)
        {
            return string.Format("{0}{1}{2}", ClientID, ClientIDSeparator, name);
        }
    }
}