using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlState.Custom
{
    public partial class Counter : System.Web.UI.UserControl
    {
        public int LeftValue { get; set; }
        public int RightValue { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadStateData();
            string button = GetValue("button");
            if (button == GetId("left"))
            {
                LeftValue++;
            }
            else if (button == GetId("right"))
            {
                RightValue++;
            }
            SaveStateData();
        }

        private void SaveStateData()
        {
            Session[GetSessionKey("left")] = LeftValue;
            Session[GetSessionKey("right")] = RightValue;
        }

        private void LoadStateData()
        {
            int temp;
            if (int.TryParse(GetValue("left"), out temp))
            {
                LeftValue = temp;
            }
            if (int.TryParse(GetValue("right"), out temp))
            {
                RightValue = temp;
            }
        }

        private string GetSessionKey(string name)
        {
            return string.Format("{0}{1}{2}", Request.Path, IdSeparator, GetId(name));
        }

        private string GetValue(string name)
        {
            string id = GetId(name);
            return Request.Form[id] ?? Request[id];
        }

        protected string GetId(string name)
        {
            return string.Format("{0}{1}{2}", ClientID, ClientIDSeparator, name);
        }
    }
}