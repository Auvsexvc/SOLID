using System;

namespace SingleResponsibility.Class
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