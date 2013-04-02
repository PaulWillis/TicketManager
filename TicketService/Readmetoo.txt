create empty asp.net web application 
Install-Package ServiceStack
add code from below to web.config
Enter classes from code from below
create global.asax
add code from below to global.asax
go to http://localhost:3688/metadata  or whatever

install rest console from chrome store
post to   http://localhost:3688/json/reply/Ticket     target uri
set content type to application/json
request payload something like

{"time":"\/Date(1364929451122)\/","amount":15}





 








  <system.webServer>
    <validation validateIntegratedModeConfiguration="false" />
    <handlers>
      <add path="*" name="ServiceStack.Factory" type="ServiceStack.WebHost.Endpoints.ServiceStackHttpHandlerFactory, ServiceStack" verb="*" preCondition="integratedMode" resourceType="Unspecified" allowPathInfo="true" />
    </handlers>
  </system.webServer>
  









using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace servicestackCustomerService3
{
    public class Ticket
    {
        public DateTime Time { get; set; }
        public int Amount { get; set; }
    }

    public class TicketResponse
    {
        public int Id { get; set; }
    }

}






using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.ServiceInterface;

namespace servicestackCustomerService3
{
    public class TicketService :Service
    {
        public object Post(Ticket request)
        {
            return new TicketResponse { Id = 1 };
        }
    }
}











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