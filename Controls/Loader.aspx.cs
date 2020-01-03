using Controls.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controls
{
    public partial class Loader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BasicCalc calc = (BasicCalc)LoadControl("~/Custom/BasicCalc.ascx");
            calc.Initial = 500;

            List<Calculation> calcs = new List<Calculation>
            {
                new Calculation { Value = 90, Operation = BasicCalc.OperationType.Plus },
                new Calculation { Value = 50, Operation = BasicCalc.OperationType.Plus }
            };
            calc.Calculations = calcs;
            controlTarget.Controls.Add(calc);
        }
    }
}