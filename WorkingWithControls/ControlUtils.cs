using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WorkingWithControls
{
    public class ControlUtils
    {
        public static void EnumerateControls(Control target, bool ignoreLiteral = false)
        {
            foreach (Control c in target.Controls.Cast<Control>())
            {
                if (!(c is LiteralControl) || !ignoreLiteral)
                {
                    Debug.WriteLine(string
                        .Format("Control ID: {0}, Type: {1}, Parent: {2}",
                        c.ID, c.GetType().Name, target.ID));
                    if (c.Controls.Count > 0)
                    {
                        EnumerateControls(c, ignoreLiteral);
                    }
                }
            }
        }
    }
}