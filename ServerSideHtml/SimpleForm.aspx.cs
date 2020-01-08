﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ServerSideHtml
{
    public partial class SimpleForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (Control c in Form.Controls)
            {
                HtmlInputControl ic = c as HtmlInputControl;
                if (ic != null)
                {
                        Debug.WriteLine("Name: {0}, Value {1}", ic.Name, ic.Value);
                }
            }
        }
    }
}