using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!" + DateTime.Now.ToShortTimeString());

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
