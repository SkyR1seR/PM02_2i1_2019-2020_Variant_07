using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text;

namespace ConsoleApplication1 
{
    class Program
    {
        // Метод, изменяющий свой аргумент
        static void changeNum(ref int n)
        {
            n = 100;         
        }
        static void Main()
        {
            int X = 0;
            Console.WriteLine("Value of x before calling changeNum: {0}",X);             
            changeNum(ref X);
            Console.WriteLine("Value of x after calling changeNum: {0}", X);
            Console.ReadLine();
        }
    }
}