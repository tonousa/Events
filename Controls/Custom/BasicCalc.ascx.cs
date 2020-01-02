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
        public enum OperationType
        {
            Plus,
            Minus
        }

        public int FirstValue { get; set; }
        public int SecondValue { get; set; }
        public OperationType Operation { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                FirstValue = int.Parse(GetFormValue("firstNumber"));
                SecondValue = int.Parse(GetFormValue("secondNumber"));
                result.InnerText = (Operation == OperationType.Plus 
                    ? (FirstValue + SecondValue) 
                    : (FirstValue - SecondValue)).ToString();
            }
            //else
            //{
            //    System.Diagnostics.Debug.WriteLine("ID: {0}, UniqueID: {1}",
            //        result.ID, result.UniqueID);
            //}
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