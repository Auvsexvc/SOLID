using System;

namespace SingleResponsibility.Class
{
    public class PdfInvoiceSaver : IInvoiceSaver
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine("Saving invoice as PDF");
        }
    }
}