using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_2_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan usia: ");
            int angka = int.Parse(Console.ReadLine());

            if (angka >= 60)
            {
                Console.WriteLine("Lansia.");
            }
            else
            {
                Console.WriteLine("Bukan lansia.");
            }
        }
    }
}
