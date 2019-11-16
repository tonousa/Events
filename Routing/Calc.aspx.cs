using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Routing
{
    public partial class Calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int firstNumber = 0, secondNumber = 0;
            string firstString, secondString, operationString;

            if (Page.RouteData.Values.Count > 0)
            {
                firstString = RouteData.Values["first"].ToString();
                secondString = RouteData.Values["second"].ToString();
                operationString = RouteData.Values["operation"].ToString();
            }
            else
            {
                firstString = Request["first"];
                secondString = Request["second"];
                operationString = Request["operation"];
            }

            if (firstString != null && secondString != null && operation != null)
            {
                first.Value = firstString;
                second.Value = secondString;
                operation.Value = operationString;
                firstNumber = int.Parse(firstString);
                secondNumber = int.Parse(secondString);
                result.InnerText = (operationString == "plus" ?
                    firstNumber + secondNumber :
                    firstNumber - secondNumber).ToString();
                resultPH.Visible = true;
            }
        }
    }
}