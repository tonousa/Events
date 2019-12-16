using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
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
            //foreach (string key in WebConfigurationManager.AppSettings)
            //{
            //    yield return string.Format("{0} = {1}",
            //        key, WebConfigurationManager.AppSettings[key]);
            //}

            //foreach (ConnectionStringSettings con in 
            //    WebConfigurationManager.ConnectionStrings)
            //{
            //    yield return string.Format("name: {0}, connectionString: {1}",
            //        con.Name, con.ConnectionString);
            //}

            //string csName = WebConfigurationManager.AppSettings["dbConnectionString"];

            //ConnectionStringSettings conString =
            //    WebConfigurationManager.ConnectionStrings[csName];

            //DbConnection dbConn = DbProviderFactories
            //    .GetFactory(conString.ProviderName).CreateConnection();

            //dbConn.ConnectionString = conString.ConnectionString;
            //dbConn.Open();

            //DbCommand dbCommand = dbConn.CreateCommand();
            //dbCommand.CommandText = "SELECT UserName from Users";
            //dbCommand.CommandType = System.Data.CommandType.Text;

            //DbDataReader reader = dbCommand.ExecuteReader();
            //while (reader.Read())
            //{
            //    yield return reader[0].ToString();
            //}

            //dbConn.Close();

            //object configObject = WebConfigurationManager
            //    .GetWebApplicationSection("system.web/compilation");
            //CompilationSection sectionHandler = configObject as CompilationSection;
            //if (sectionHandler != null)
            //{
            //    yield return string.Format("debug = {0}", sectionHandler.Debug);
            //    yield return string.Format("targetFramework = {0}", sectionHandler.TargetFramework);
            //    yield return string.Format("batch = {0}", sectionHandler.Batch);

            //}
            //else
            //{
            //    yield return string.Format("unexpected object type = {0}",
            //        sectionHandler.GetType());

            //}

            Configuration config = WebConfigurationManager.OpenWebConfiguration(Request.Path);

            //PlacesSection places = (PlacesSection)config.Sections["places"];

            UserAndPlaceSectionGroup group
                = (UserAndPlaceSectionGroup)config.SectionGroups["customDefaults"];
            PlacesSection places = group.Places;

            Place defaultPlace = places.Places[places.Default];
            yield return string.Format("the default is: {0} (City: {1}, Country: {2})",
                places.Default, defaultPlace.City, defaultPlace.Country);

            foreach (Place p in places.Places)
            {
                yield return string.Format("{0} {1}", p.City, p.Country);
            }

            //newUserDefaultsSection section = 
            //    (newUserDefaultsSection)config.Sections["newUserDefaults"];

            //yield return string.Format("city = {0}", section.City);
            //yield return string.Format("country = {0}", section.Country);
            //yield return string.Format("language = {0}", section.Language);
            //yield return string.Format("region = {0}", section.Region);
            //foreach (ConfigurationSectionGroup group in config.SectionGroups)
            //{
            //    foreach (string str in processSectionGroup(group))
            //    {
            //        yield return str;
            //    }
            //}

            //SystemWebSectionGroup group =
            //    (SystemWebSectionGroup)config.SectionGroups["system.web"];
            //CompilationSection section = group.Compilation;
            //yield return string.Format("debug = {0}", group.Compilation.Debug);
            //yield return string.Format("targetframework = {0}", group.Compilation.TargetFramework);
            //yield return string.Format("batch = {0}", group.Compilation.Batch);
        }

        private IEnumerable<string> processSectionGroup(ConfigurationSectionGroup group)
        {
            yield return string.Format("<b>Section group: {0}</b>", group.Name);
            foreach (ConfigurationSectionGroup innerGroup in group.SectionGroups)
            {
                processSectionGroup(innerGroup);
            }
            foreach (ConfigurationSection section in group.Sections)
            {
                yield return string.Format("Section: {0}", section.SectionInformation.Name);
            }
        }
    }
}