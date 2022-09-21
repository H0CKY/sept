using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy egész számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adjon meg még egy egész számot!");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("A nagyobb szam:{0}", a);
            }
            else { Console.WriteLine("A nagyobb szam:{0}", b); }

            Console.ReadLine();
        }
    }
}
