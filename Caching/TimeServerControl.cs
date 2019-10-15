using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caching
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:TimeServerControl runat=server></{0}:TimeServerControl>")]
    [PartialCaching(60, VaryByParams ="none", Shared =true)]
    public class TimeServerControl : WebControl
    {
        //[Bindable(true)]
        //[Category("Appearance")]
        //[DefaultValue("")]
        //[Localizable(true)]
        //public string Text
        //{
        //    get
        //    {
        //        String s = (String)ViewState["Text"];
        //        return ((s == null) ? String.Empty : s);
        //    }

        //    set
        //    {
        //        ViewState["Text"] = value;
        //    }
        //}

        protected override void RenderContents(HtmlTextWriter output)
        {
            //output.Write(Text);
            output.WriteFullBeginTag("div");
            output.Write("The server control time is: {0}",
                DateTime.Now.ToLongTimeString());
            output.WriteEndTag("div");
        }
    }
}
