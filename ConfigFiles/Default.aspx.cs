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

            string csName = WebConfigurationManager.AppSettings["dbConnectionString"];

            ConnectionStringSettings conString =
                WebConfigurationManager.ConnectionStrings[csName];

            DbConnection dbConn = DbProviderFactories
                .GetFactory(conString.ProviderName).CreateConnection();

            dbConn.ConnectionString = conString.ConnectionString;
            dbConn.Open();

            DbCommand dbCommand = dbConn.CreateCommand();
            dbCommand.CommandText = "SELECT UserName from Users";
            dbCommand.CommandType = System.Data.CommandType.Text;

            DbDataReader reader = dbCommand.ExecuteReader();
            while (reader.Read())
            {
                yield return reader[0].ToString();
            }

            dbConn.Close();
        }
    }
}