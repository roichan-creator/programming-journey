using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out angka))
                {
                    Console.WriteLine("input tidak valid. silakan masukkan angka.");
                    angka = 1;
                    continue;
                }
                if (angka % 2 != 0)
                {
                    Console.WriteLine($"angka {angka} adalah ganjil. coba lagi.");
                }
            } while (angka % 2 != 0);
            Console.WriteLine($"selamat! Anda memasukkan angka genap: {angka}");

        }
    }
}
