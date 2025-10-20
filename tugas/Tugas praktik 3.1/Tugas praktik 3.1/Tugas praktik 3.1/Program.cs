using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_praktik_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("MAsukkan bilangan pertama:       ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan bilangan kedua:        ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan bilangan ketiga:        ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Operasi Matematika
            double penjumlahan = a + b + c;
            double pengurangan = a - b - c;
            double perkalian = a * b * c;
            double pembagian = a / b / c;  //dibagi berurutan:(a÷b)÷c

            //Hasil
            Console.WriteLine("\n=== HASIL PERHITUNGAN===");
            Console.WriteLine($"Penjumlahan :{a}+ {b}+{c}= {penjumlahan}");
            Console.WriteLine($"Penguranagn :{a}- {b}-{c}= {pengurangan}");
            Console.WriteLine($"Penjumlahan :{a}× {b}×{c}= {perkalian}");
            Console.WriteLine($"Penjumlahan :{a}÷ {b}÷{c}= {pembagian}");

            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();

        }
    }
}
