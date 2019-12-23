using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithControls
{
    public class ButtonCountResult
    {
        public int Index { get; set; }
        public int Count { get; set; }
    }

    public partial class TripleButtonControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int index;
            if (IsPostBack && int.TryParse(Request.Form["button"], out index))
            {
                GetClickCounts()[index].Count++;
            }
            //ControlUtils.EnumerateControls(this);
        }

        public ButtonCountResult[] GetClickCounts()
        {
            ButtonCountResult[] data;
            if ((data = (ButtonCountResult[])Session["triple_data"]) == null)
            {
                Session["triple_data"] = data = new ButtonCountResult[3];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = new ButtonCountResult { Index = i };
                }
            }
            return data;
        }
    }
}