using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlState.Custom
{
    public partial class Calc : System.Web.UI.UserControl
    {
        private List<string> history = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            CalcState state = ViewState["state"] as CalcState;
            if (state != null)
            {
                firstValue.Value = state.FirstValue;
                secondValue.Value = state.SecondValue;
                history = state.History;
            }
            else
            {
                firstValue.Value = "10";
                secondValue.Value = "31";
            }

            if (IsPostBack)
            {
                int result = int.Parse(firstValue.Value) + int.Parse(secondValue.Value);
                resultValue.InnerText = result.ToString();
                history.Insert(0, string.Format("{0} + {1} = {2}",
                    firstValue.Value, secondValue.Value, result));
                ViewState["state"] = new CalcState
                {
                    FirstValue = firstValue.Value,
                    SecondValue = secondValue.Value,
                    History = history
                };
            }
        }

        protected void HandleClick(object sender, EventArgs e)
        {
            int result = int.Parse(firstValue.Value) + int.Parse(secondValue.Value);
            resultValue.InnerText = result.ToString();
            history.Insert(0, string.Format("{0} + {1} = {2}",
                firstValue.Value, secondValue.Value, result));
            ViewState["state"] = new CalcState
            {
                FirstValue = firstValue.Value,
                SecondValue = secondValue.Value,
                History = history
            };
        }

        public IEnumerable<System.String> GetHistory()
        {
            return history.Take(3);
        }

        private class CalcState
        {
            public string FirstValue { get; set; }
            public string SecondValue { get; set; }
            public List<string> History { get; set; }
        }
    }
}