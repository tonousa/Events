using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConfigFiles
{
    public partial class SelectCity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Place> GetPlaces()
        {
            return ((PlacesSection)WebConfigurationManager
                .GetWebApplicationSection("customDefaults/places"))
                .Places.Cast<Place>();
        }
    }
}