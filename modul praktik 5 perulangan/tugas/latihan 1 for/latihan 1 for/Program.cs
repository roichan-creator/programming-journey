using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_1_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabel perkalian 5");
            int n = 5;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " X " + i + " = " + (n*i));
            }
        }
    }
}
