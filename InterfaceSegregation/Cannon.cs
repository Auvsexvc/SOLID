using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class Cannon : IPrinter, IFax
    {
        public void Fax(string content)
        {
            Console.WriteLine("Cannon FAX");
        }

        public void PrintColor(string content)
        {
            Console.WriteLine("CANNON Print color");
        }

        public void PrintGrey(string content)
        {
            Console.WriteLine("CANNON Print MONO");
        }
    }
}
