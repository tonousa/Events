using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManagingUsers.Admin
{
    public class UserDetails
    {
        public string Name { get; set; }
        public string Roles { get; set; }
        public bool Locked { get; set; }
        public bool Online { get; set; }
    }

    public partial class Manage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (true)
                {

                }
            }
        }
    }
}