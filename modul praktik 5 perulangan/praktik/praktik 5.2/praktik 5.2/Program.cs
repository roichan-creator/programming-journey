using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 1; i <= 5; i++)
            {
                total = total + i;
                Console.WriteLine(" manambahkan " + i + ", total sementara =" + total);
            }
            Console.WriteLine("\nHasil akhir penjumlahan adalah: " + total);
        }
    }
}
