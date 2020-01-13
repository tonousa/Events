using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Data.Controls
{
    public class DatatSelect : DataBoundControl, INamingContainer
    {
        private object[] dataArray;

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

        [TemplateContainer(typeof(ElementItem))]
        public ITemplate ItemTemplate { get; set; }

        protected override void PerformDataBinding(IEnumerable data)
        {
            //dataArray = data.Cast<string>().ToArray();
            ViewState["data"] = dataArray = data.Cast<object>().ToArray();
        }

        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Name, GetId("customSelect"));
            writer.RenderBeginTag(HtmlTextWriterTag.Select);
            for (int i = 0; i < dataArray.Length; i++)
            {
                ElementItem elem = new ElementItem(i, dataArray[i]);
                ItemTemplate.InstantiateIn(elem);
                elem.DataBind();
                elem.RenderControl(writer);

                //writer.AddAttribute(HtmlTextWriterAttribute.Value, dataArray[i]);
                //if (i == 0 && Value == null || dataArray[i] == Value)
                //{
                //    writer.AddAttribute(HtmlTextWriterAttribute.Selected, "selected");
                //}
                //writer.RenderBeginTag(HtmlTextWriterTag.Option);
                //writer.Write(dataArray[i]);
                //writer.RenderEndTag();
            }
            writer.RenderEndTag();
        }

        private string GetId(string name)
        {
            return string.Format("{0}{1}{2}", ClientID, ClientIDSeparator, name);
        }
    }

    public class ElementItem : Control, IDataItemContainer
    {
        public ElementItem(int index, object dataItem)
        {
            DataItemIndex = index;
            DataItem = dataItem;
        }
        public object DataItem { get; set; }
        public int DataItemIndex { get; set; }
        public int DisplayIndex {
            get {
                return DataItemIndex;
            }
        }
    }
}