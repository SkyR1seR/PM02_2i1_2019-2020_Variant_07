using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите X");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y = " + (x+ 2*x*x+3*x));
            Console.ReadKey();
        }
    }
}
