using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS_PRAKTIK_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== program operator nilai siswa ===");

            Console.Write("NAMA SISWA                       :");
            string nama = Console.ReadLine();
            Console.Write("KELAS                            :");
            string kls = Console.ReadLine();
            Console.Write("Masukkan Nilai matematika        :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Nilai bahasa indonesia  :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Nilai bahasa inggris    :");
            int c = Convert.ToInt32(Console.ReadLine());
            int rata_rata = (a + b + c) / 3;
            Console.WriteLine("nilai rata rata              = " + rata_rata);
            Console.Write("====================================");
            Console.WriteLine("\nNilai rata rata siswa");
            Console.WriteLine($"NAMA SISWA              : {nama}");
            Console.WriteLine($"KELAS                   : {kls}");
            Console.WriteLine($"nilai matematika        : " + a);
            Console.WriteLine($"nilai bahasa indonesia  : " + b);
            Console.WriteLine($"nilai bahasa inggris    : " + c);
            Console.WriteLine($"nilai rata rata         : " + rata_rata);
        }
    }
}
