using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_works.SCR.DIP
{
    public class Book
    {
        public string Text { get; set; }
        public IPrinter Printer { get; set; }
        public Book(IPrinter printer) { 
            this.Printer = printer;
        }

        public void Print() {
            Printer.Print(Text);
        }
    }
}
