using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectCar
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Opel"); 

            c1.Start();
            Console.WriteLine(c1.GetName());
            }
    }
}
