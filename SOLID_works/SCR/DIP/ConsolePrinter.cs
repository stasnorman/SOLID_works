using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_works.SCR.DIP
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string Text)
        {
            Console.WriteLine("Печать на консоли");
        }
    }
}
