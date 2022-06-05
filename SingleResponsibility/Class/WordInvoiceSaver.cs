using System;

namespace SingleResponsibility.Class
{
    public class WordInvoiceSaver : IInvoiceSaver
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine("Saving invoice as Word");
        }
    }
}