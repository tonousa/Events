using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ConfigFiles
{
    public class UserAndPlaceSectionGroup : ConfigurationSectionGroup
    {
        [ConfigurationProperty("newUserDefaults")]
        public newUserDefaultsSection NewUserDefaults
        {
            get { return (newUserDefaultsSection)Sections["newUserDefaults"]; }
        }

        [ConfigurationProperty("places")]
        public PlacesSection Places
        {
            get { return (PlacesSection)Sections["places"]; }
        }
    }
}