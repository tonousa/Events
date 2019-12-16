using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConfigFiles.Admin
{
    public partial class FolderForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<string> GetConfig()
        {
            newUserDefaultsSection defaults =
                (newUserDefaultsSection)WebConfigurationManager
                    .GetSection("customDefaults/newUserDefaults");
            yield return string.Format("Defaults: {0}, {1}, {2}, {3}",
                defaults.City, defaults.Country, defaults.Language, defaults.Region);

            PlacesSection places =
                (PlacesSection)WebConfigurationManager
                    .GetSection("customDefaults/places");
            foreach (Place place in places.Places)
            {
                yield return string.Format("Place: {0}, {1}, {2}",
                    place.Code, place.City, place.Country);
            }
        }
    }
}