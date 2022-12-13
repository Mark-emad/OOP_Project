using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVOICE_supermarket
{
    internal class recipt
    {
        public int id { get; set; }
        public string Product_name { get; set; }
        public double Price { get; set; }   
        public int Quantity { get; set; }
        public string Total { get { return string.Format("{0}£E", Price * Quantity); } }

    }
}
