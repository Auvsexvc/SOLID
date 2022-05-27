using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class HpLaserJet : IPrinter, IFax, IScanner
    {
        public void Fax(string content)
        {
            Console.WriteLine("HP Fax");
        }

        public void PrintColor(string content)
        {
            Console.WriteLine("HP Print Color");
        }

        public void PrintGrey(string content)
        {
            Console.WriteLine("HP print color");
        }

        public void Scan(string content)
        {
            Console.WriteLine("HP Scan");
        }
    }
}
