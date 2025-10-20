using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan angka pertama: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("masukkan angkka kedua: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hasil perkalian: " + (a * b));
            Console.Write("masukkan angka ketiga: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("masukkan angka keempat: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("hasil perkalian (double): " + (c * d));
        }
    }
}
