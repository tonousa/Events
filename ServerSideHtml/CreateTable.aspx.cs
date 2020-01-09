using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ServerSideHtml
{
    public partial class CreateTable : System.Web.UI.Page
    {
        private List<string[]> tableRows = new List<string[]>
        {
            new string[] {"Red", "2"},
            new string[] {"Green", "41"},
            new string[] {"Blue", "3"},
        };

        public IEnumerable<string[]> GetRows()
        {
            return tableRows;
        }

        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    HtmlTable table = new HtmlTable();

        //    HtmlTableRow headerRow = new HtmlTableRow();
        //    headerRow.Cells.Add(new HtmlTableCell("th") { InnerText = "Color" });
        //    headerRow.Cells.Add(new HtmlTableCell("th") { InnerText = "Count" });
        //    table.Rows.Add(headerRow);

        //    foreach (string[] data in tableRows)
        //    {
        //        table.Rows.Add(new HtmlTableRow
        //        {
        //            Cells =
        //            {
        //                new HtmlTableCell {InnerText = data[0] },
        //                new HtmlTableCell {InnerText =  data[1] }
        //            }
        //        });
        //    }

        //    HtmlTableRow footerRow = new HtmlTableRow();
        //    footerRow.Cells.Add(new HtmlTableCell("th") { InnerText = "Total" });
        //    footerRow.Cells.Add(new HtmlTableCell("th") { InnerText = "46" });
        //    table.Rows.Add(footerRow);

        //    container.Controls.Add(table);
        //}
    }
}