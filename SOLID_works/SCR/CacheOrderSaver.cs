using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_works.SCR
{
    public class CacheOrderSaver : IOrderSaver, IDelete
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(string name)
        {
            Console.WriteLine(name);
        }
    }
}
