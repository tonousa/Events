using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientDev
{
    public class ValidationRepeater : DataBoundControl, INamingContainer
    {
        [TemplateContainer(typeof(ValidationRepeaterTemplateItem))]
        public ITemplate PropertyTemplate { get; set; }

        public string Properties { get; set; }
        public string ModelType { get; set; }

        private bool IsAttrDefined(Type attrType, Type targetType, string propName)
        {
            return Attribute.IsDefined(targetType.GetProperty(propName), attrType);
        }

        protected override void RenderContents(HtmlTextWriter writer)
        {

        }
    }



    public class ValidationRepeaterTemplateItem
    {
        public string PropertyName { get; set; }
        public string ValidationAttributes { get; set; }
    }
}