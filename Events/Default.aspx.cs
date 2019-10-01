using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Events
{
    public partial class Default : System.Web.UI.Page
    {
        
        public IEnumerable<EventDescription> GetEvents()
        {
            return EventCollection.Events;
        }

        protected void HandleEvent(object src, ViewCounterEventArgs args)
        {
            EventCollection.Add(EventSource.Page,
                string.Format("Control - Counter: {0}", args.Counter));
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Page, "PreInit");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Page, "Init");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Page, "InitComplete");
            //counter.Count += (csrc, cargs) =>
            //{
            //    EventCollection.Add(EventSource.Page,
            //        string.Format("Control - Counter: {0}", cargs.Counter));
            //};
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Page, "PreLoad");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Page, "Load");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Page, "LoadComplete");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Page, "PreRender");
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Page, "PreRenderComplete");
        }

        protected void Page_SaveStateComplete(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Page, "SaveStateComplete");
        }

        protected override void Render(HtmlTextWriter writer)
        {
            EventCollection.Add(EventSource.Page, "Render");
            base.Render(writer);
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Page, "Unload");
        }

    }
}