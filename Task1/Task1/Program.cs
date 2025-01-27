using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int num_1;
            int num_2;

            Console.WriteLine("Введіть перше число:");
            num_1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            num_2 = int.Parse(Console.ReadLine());

            int sum = num_1 + num_2;

            Console.WriteLine($"Сума чисел {num_1} та {num_2} дорівнює {sum}");
        }
    }
}
