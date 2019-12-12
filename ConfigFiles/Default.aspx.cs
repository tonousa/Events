using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConfigFiles
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<string> GetConfig()
        {
            foreach (string key in WebConfigurationManager.AppSettings)
            {
                yield return string.Format("{0} = {1}",
                    key, WebConfigurationManager.AppSettings[key]);
            }
        }
    }
}