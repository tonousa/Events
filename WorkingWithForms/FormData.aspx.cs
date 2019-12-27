using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithForms
{
    public class FormKeyValuePair
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public partial class FormData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                DataBind();
            }
        }

        public IEnumerable<FormKeyValuePair> GetFormData()
        {
            var keys = Request.Form.Keys.Cast<string>().Where(k => !k.StartsWith("__"));
            foreach (string key in keys)
            {
                yield return new FormKeyValuePair
                {
                    Key = key,
                    Value = Request.Form[key]
                };
            }
        }
    }
}