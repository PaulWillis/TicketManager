using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketService
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