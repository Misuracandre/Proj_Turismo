using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class TicketController
    {
        private TicketService ticketService;

        public TicketController()
        {
            ticketService = new TicketService();
        }

        public bool Insert(Ticket ticket)
        {
            return ticketService.Insert(ticket);
        }

        public List<Ticket> GetAll()
        {
            return ticketService.GetAll();
        }
    }
}
