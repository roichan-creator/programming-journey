using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_2_imt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== program imt ====");
            Console.Write("masukkan berat badan (kg): ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("masukkan tinggi badan (m): ");
            double b = Convert.ToDouble(Console.ReadLine());
            double imt = a / (b * b);
            Console.WriteLine("--- HASIL ---");
            Console.WriteLine("berat badan  = " + a + "kg");
            Console.WriteLine("tinggi badan = " + b + "m");
            Console.WriteLine("imt          = " + imt );
            if (imt >= 30)
                Console.WriteLine("kategori = obesitas");
            if (imt >= 25)
                Console.WriteLine("kategori = kelebihan berat badan");
            if (imt >= 18.5)
                Console.WriteLine("kategori = normal");
            else
                Console.WriteLine("kategori = kurus");
        }
    }
}
