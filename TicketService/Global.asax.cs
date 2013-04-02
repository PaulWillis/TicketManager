using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using ServiceStack.WebHost.Endpoints;

namespace TicketService
{

    public class Global : System.Web.HttpApplication
    {

        public class TicketTrackerAppHost : AppHostBase
        {
            public TicketTrackerAppHost()
                : base("Ticket Tracker", typeof(TicketService).Assembly)
            {

            }

            public override void Configure(Funq.Container container)
            {
            }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            new TicketTrackerAppHost().Init();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}