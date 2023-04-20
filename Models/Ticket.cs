using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public Address Origin { get; set; }
        public Address Destination { get; set; }
        public Client Client { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
    }
}
