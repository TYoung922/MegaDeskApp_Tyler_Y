using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaDeskApp;

namespace MegaDeskApp
{
    public class DeskQuote
    {
        public string customerName { get; set; }
        public string orderDate { get; set; }
        public Desk desk { get; set; }
        public string shippingDays { get; set; }

        public DeskQuote()
        {
            customerName = string.Empty;
            desk = new Desk();
        }
    }
}
