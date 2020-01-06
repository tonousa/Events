using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ControlState.Custom
{
    public class SimpleTime : System.Web.UI.WebControls.WebControl
    {
        private bool stateful;
        private string timestamp;

        public SimpleTime()
        {
            Load += (src, args) =>
            {
                if ((timestamp = ViewState["time"] as string) != null)
                {
                    stateful = true;
                }
                else
                {
                    timestamp = DateTime.Now.ToLongTimeString();
                }
            };

            PreRender += (src, args) =>
            {
                ViewState["time"] = timestamp;
            };
        }

        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
            writer.Write(string.Format("Time: {0} ({1})",
                timestamp, stateful ? "State" : "New"));
            writer.RenderEndTag();
        }
    }
}