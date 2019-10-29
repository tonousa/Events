using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ErrorHandling
{
    public partial class SumControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int? first = GetIntValue("first");
                int? second = GetIntValue("second");

                if (first.HasValue && second.HasValue)
                {
                    result.InnerText = (first + second).ToString();
                    resultPlaceholder.Visible = true;
                }
                else
                {
                    Context.AddError(new Exception("Cannot perform calculation"));
                }
                
            }
        }

        private int? GetIntValue(string name)
        {
            int value;
            if (Request[name] == null)
            {
                Context.AddError(new ArgumentNullException(name));
                return null;
            }
            else if (!int.TryParse(Request[name], out value))
            {
                Context.AddError(new ArgumentOutOfRangeException(name));
                return null;
            }
            return value;
        }
    }
}