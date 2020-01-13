using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Data.Controls
{
    public class DatatSelect : DataBoundControl
    {
        private string[] dataArray;

        public DatatSelect()
        {
            Load += (src, args) =>
            {
                //ViewStateMode = System.Web.UI.ViewStateMode.Disabled;
                dataArray = ViewState["data"] as string[];
                if (dataArray == null)
                {
                    DataBind();
                }
            };
        }

        public string Value
        {
            get
            {
                return Context.Request.Form[GetId("customSelect")];
            }
        }

        protected override void PerformDataBinding(IEnumerable data)
        {
            //dataArray = data.Cast<string>().ToArray();
            ViewState["data"] = dataArray = data.Cast<string>().ToArray();
        }

        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Name, GetId("customSelect"));
            writer.RenderBeginTag(HtmlTextWriterTag.Select);
            for (int i = 0; i < dataArray.Length; i++)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Value, dataArray[i]);
                if (i == 0 && Value == null || dataArray[i] == Value)
                {
                    writer.AddAttribute(HtmlTextWriterAttribute.Selected, "selected");
                }
                writer.RenderBeginTag(HtmlTextWriterTag.Option);
                writer.Write(dataArray[i]);
                writer.RenderEndTag();
            }
            writer.RenderEndTag();
        }

        private string GetId(string name)
        {
            return string.Format("{0}{1}{2}", ClientID, ClientIDSeparator, name);
        }
    }
}