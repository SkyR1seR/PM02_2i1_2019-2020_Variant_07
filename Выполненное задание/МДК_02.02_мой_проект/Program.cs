using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите X");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y = " + result(x));
            Console.ReadKey();
        }

        public static int result(int x)
        {
            return (x + 2 * x * x + 3 * x);
        }
    }
}
