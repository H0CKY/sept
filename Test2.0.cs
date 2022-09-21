using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy egész számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adjon meg még egy egész számot!");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
