using Binding.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;

namespace Binding
{
    public partial class Data : System.Web.UI.Page
    {
        //private int maxValue;
        //private string operation;

        //protected void Page_LoadComplete(object sender, EventArgs e)
        //{
        //    if (IsPostBack)
        //    {
        //        maxValue = int.Parse(max.Value);
        //        OperationSelector selector =
        //            FindControl("opSelector") as OperationSelector;
        //        if (selector != null)
        //        {
        //            operation = selector.SelectedOperator;
        //        }
        //    }
        //}

        public IEnumerable<string> GetData([Form] int? max,
            [Control("opOperator", "selectedOperator")] string operation)
        {
            if (operation != null)
            {
                for (int i = 1; i < max; i++)
                {
                    yield return string.Format("{0} {1} {2} = {3}",
                        max, 
                        operation == "Add" ? "+" : "-",
                        i, 
                        operation == "Add" ? (max + i) : (max- 1));
                }
            }
        }
    }
}