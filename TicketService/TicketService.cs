using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.ServiceInterface;

namespace TicketService
{
    public class TicketService : Service
    {
        public object Post(Ticket request)
        {
            return new TicketResponse { Id = 1 };
        }
    }
}