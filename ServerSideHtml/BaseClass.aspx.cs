using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSideHtml
{
    public partial class BaseClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            userInput.Attributes["class"] = "user";

            foreach (string key in userInput.Attributes.Keys)
            {
                Debug.WriteLine("Attribute {0}: {1}", key, userInput.Attributes[key]);
            }

            Debug.WriteLine(string.Format("tag name: {0}", userInput.TagName));
        }
    }
}