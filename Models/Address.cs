using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Neighborhood { get; set; }
        public string ZipCode { get; set; }
        public string Unit { get; set; }
        public City City { get; set; }
        public DateTime Registration_Date { get; set; }
    }
}
