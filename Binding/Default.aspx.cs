using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using Binding.Models;
using System.Text.RegularExpressions;

namespace Binding
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                DisplayPerson(GetPerson());
            }
        }

        private Person GetPerson()
        {
            Person model = new Person();

            IValueProvider provider =
                new FormValueProvider(ModelBindingExecutionContext);

            if (TryUpdateModel<Person>(model, provider))
            {
                return model;
            }
            else
            {
                throw new FormatException("could not bind model");
            }

            //model.Name = Request.Form["name"];
            //model.Age = int.Parse(Request.Form["age"]);
            //model.Cell = Request.Form["cell"];
            //model.Zip = Request.Form["zip"];
            //return model;

            //string nameFormValue = Request.Form["name"];
            //if (nameFormValue == null || nameFormValue == string.Empty)
            //{
            //    throw new FormatException("Provide name");
            //}
            //else if (nameFormValue.Length < 3 || nameFormValue.Length > 20)
            //{
            //    throw new FormatException("name must be 3-20 chars");
            //}
            //else if (!Regex.IsMatch(nameFormValue, @"^[A-Za-z\s]+$"))
            //{
            //    throw new FormatException("only letters and spaces");
            //}
            //else
            //{
            //    model.Name = nameFormValue;
            //}

            //string ageFormValue = Request.Form["age"];
            //if (ageFormValue == null || ageFormValue == String.Empty)
            //{
            //    throw new FormatException("provide age");
            //}
            //else 
            //{
            //    int ageValue;
            //    if (!int.TryParse(ageFormValue, out ageValue))
            //    {
            //        throw new FormatException("provide age in years");
            //    }
            //    else
            //    {
            //        if (ageValue < 5 || ageValue > 100)
            //        {
            //            throw new FormatException("age bet 5 and 100");
            //        }
            //        else
            //        {
            //            model.Age = ageValue;
            //        }
            //    }
            //}

            //model.Cell = Request.Form["cell"];
            //model.Zip = Request.Form["zip"];
            //return model;
        }

        private void DisplayPerson(Person person)
        {
            sname.InnerText = person.Name;
            sage.InnerText = person.Age.ToString();
            scell.InnerText = person.Cell;
            szip.InnerText = person.Zip;
        }
    }
}