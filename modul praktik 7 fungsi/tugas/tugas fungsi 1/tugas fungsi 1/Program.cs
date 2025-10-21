using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_fungsi_1
{
    internal class Program
    {
        static double Kali(double x, double y, double z)
        {
            return x * y * z;
        }
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka pertama: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka ketiga: ");
            double z = Convert.ToDouble(Console.ReadLine());

            double hasil = Kali(x, y, z);
            Console.WriteLine("hasil perkalian: " + hasil);
        }
    }
}
