﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithForms
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack)
            if (Request.HttpMethod == "POST")
            {
                if (Request.Form["action"] == "click")
                {
                    result.InnerText = "Clicked";
                }
                else
                {
                    result.InnerText = "Not Clicked";
                }
            }
        }
    }
}