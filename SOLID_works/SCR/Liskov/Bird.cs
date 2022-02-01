using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_works.SCR.Liskov
{
    public class Bird
    {
        public string Name { get; set; }

        public Bird(string action)
        {
            this.Name = action;
        }

        public void Fly()
        {
            Console.WriteLine("Летит");
        }
    }

    public class Pegeot: Bird
    {
        public Pegeot(string Name, string skorost) : base(Name) {
            this.Skorost = skorost;
        }
        public string Skorost { get; }

        public void TestMethod() { 
        Console.WriteLine($"{ Skorost} + { Name }");
        }
    }

    public class Straust : Bird
    {
        public Straust(string action) : base(action)
        {
        }
    }

}
