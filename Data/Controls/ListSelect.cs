using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Data.Controls
{
    public class ListSelect : DataBoundControl
    {
        private ListItemDetails[] dataItems;
    }

    [Serializable]
    public class ListItemDetails
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public bool Selected { get; set; }

        public static ListItemDetails[] Create(ListItem[] items, out string selected)
        {
            ListItemDetails[] result = new ListItemDetails[items.Length];
            selected = null;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Selected)
                {
                    selected = items[i].Value;
                }
                result[i] = new ListItemDetails
                {
                    Text = items[i].Text,
                    Value = items[i].Value,
                    Selected = items[i].Selected
                };
            }
            return result;
        }
    }
}