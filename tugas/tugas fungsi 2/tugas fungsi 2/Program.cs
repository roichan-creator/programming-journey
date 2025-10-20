using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_fungsi_2
{
    internal class Program
    {
        static double ratarata(double x, double y, double z)
        {
            double ratarata = (x + y + z) / 3;
            return ratarata;
        }
        static void Main(string[] args)
        {
            Console.Write("Masukkan Nilai pertama: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Nilai kedua: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Nilai ketiga: ");
            double z = Convert.ToDouble(Console.ReadLine());

            double hasil = ratarata(x, y, z);
            Console.WriteLine("Hasil ratarata dari ketiga nilai adalah: " + hasil);
        }
    }
}
