using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan angka");
            int angka = int.Parse(Console.ReadLine());
            if (angka >= 0)
                Console.WriteLine("Angka positif.");
            else
                Console.WriteLine("Angka negatif.");
        }
    }
}
