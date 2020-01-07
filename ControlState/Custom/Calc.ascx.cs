using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlState.Custom
{
    [Serializable]
    public class CalcState
    {
        public List<string> History { get; set; }
    }

    public partial class Calc : System.Web.UI.UserControl
    {
        private List<string> history = new List<string>();

        protected void Page_Init(object sender, EventArgs e)
        {
            Page.RegisterRequiresControlState(this);
        }

        protected override void LoadControlState(object savedState)
        {
            history = savedState as List<string> ?? new List<string>();
        }

        protected override object SaveControlState()
        {
            return history.Count > 3 ? history.GetRange(0, 3) : history;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //CalcState state = ViewState["state"] as CalcState;
            //if (state != null)
            //{
            //    history = state.History;
            //}

            if (IsPostBack)
            {
                int result = int.Parse(firstValue.Value) + int.Parse(secondValue.Value);
                resultValue.InnerText = result.ToString();
                history.Insert(0, string.Format("{0} + {1} = {2}",
                    firstValue.Value, secondValue.Value, result));
                ViewState["state"] = new CalcState
                {
                    History = history.Count > 3 ? history.GetRange(0,3) : history
                };
                DataBind();
            }
        }

        public IEnumerable<string> GetHistory()
        {
            return history;
        }

    }
}