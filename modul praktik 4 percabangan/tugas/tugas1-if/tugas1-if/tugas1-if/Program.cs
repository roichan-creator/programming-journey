using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas1_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apakah lebih besar dari 100?");
            Console.Write("Masukkan angka: ");
            int angka = int.Parse(Console.ReadLine());

            if (angka >= 100)
            {
                Console.WriteLine("Lebih besar.");
            }
        }
    }
}
