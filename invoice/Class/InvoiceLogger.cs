using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class InvoiceLogger
    {
        private Invoice _invoice;

        public InvoiceLogger(Invoice invoice)
        {
            _invoice = invoice;
        }

        public void Display()
        {
            Console.WriteLine(_invoice.Vendor);
            Console.WriteLine(_invoice.Vendee);
            Console.WriteLine(_invoice.Total);
        }
    }
}