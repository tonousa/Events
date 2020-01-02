using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controls.Custom
{
    public class ServerCalc : WebControl
    {
        private int? total = null;

        public ServerCalc()
        {
            Load += (src, args) =>
            {
                if (Context.Request.HttpMethod == "POST")
                {
                    total = int.Parse(GetFormValue("initialVal"));
                    string[] numbers = GetFormValue("calcValue").Split(',');
                    string[] operators = GetFormValue("calcOp").Split(',');
                    for (int i = 0; i < operators.Length; i++)
                    {
                        int val = int.Parse(numbers[i]);
                        total += operators[i] == "Plus" ? val : 0 - val;
                        Calculations[i].Value = val;
                    }
                }
            };
        }

        public int Initial { get; set; }
        public List<Calculation> Calculations { get; set; }

        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.Write("This is the ServerCalc control");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);


        }

        protected string GetFormValue(string name)
        {
            return Context.Request.Form[GetId(name)];
        }

        protected string GetId(string name)
        {
            return string.Format("{0}{1}{2}", ClientID, ClientIDSeparator, name);
        }
    }
}