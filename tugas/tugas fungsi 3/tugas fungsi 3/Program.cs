using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_fungsi_3
{
    internal class Program
    {
        static double konversisuhu(double c)
        {
            return (c * 9 / 5.0) + 32;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== KONVERSI SUHU DARI CELCIUS KE FAHRENHEIT");
            Console.Write("Masukkan suhu: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double hasil = konversisuhu (c);
            Console.WriteLine("Hasil konversi suhu adalah: " + hasil + "°F");
        }
    }
}
