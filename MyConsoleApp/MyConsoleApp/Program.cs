using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, GitHub & Medium!");
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("Toplam: "+sum);
            Console.ReadKey();
        }
    }
}
