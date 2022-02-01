using SOLID_works.SCR.ObjectUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_works.SCR
{
    public class DbOrderSaver: IOrderSaver
    {
        public void Save(string name) {
             Console.WriteLine(name);
        }
    }
}
