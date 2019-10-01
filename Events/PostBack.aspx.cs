﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Events
{
    public partial class PostBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            firstPH.Visible = !(secondPH.Visible = IsPostBack);

            if (IsPostBack)
            {
                int firstNum = int.Parse(firstNumber.Value);
                int secondNum = int.Parse(secondNumber.Value);
                result.InnerText = (firstNum + secondNum).ToString();
            }
        }
    }
}