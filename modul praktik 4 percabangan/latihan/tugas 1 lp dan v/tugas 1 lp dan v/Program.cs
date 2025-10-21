using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_1_lp_dan_v
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM MENGITUNG LP DAN V ===");
            Console.WriteLine("PILIH JENIS BANGUN RUANG");
            Console.WriteLine("1. volume kubus");
            Console.WriteLine("2. luas permukaan kubus");
            Console.WriteLine("3. volume balok");
            Console.WriteLine("4. luas permukaan balok");
            Console.Write("masukkan pilihan (1-4): ");
            int jenis = int.Parse(Console.ReadLine());

            switch (jenis)
            {
                case 1:Console.WriteLine(" anda telah memilih volume kubus");
                Console.Write("masukkan sisi kubus: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("volume kubus: " + (a * a * a)); break;
            
                case 2:Console.WriteLine(" anda telah memilih luas permukaan kubus");
                Console.Write("masukkan sisi kubus: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("luas permukaan kubus: " + (6 * b)); break;

                case 3:Console.WriteLine(" anda telah memilih volume balok");
                Console.Write("masukkan panjang balok: ");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.Write("masukkan lebar balok: ");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.Write("masukkan tinggi balok: ");
                int e = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("volume balok: " + (c * d * e)); break;

                case 4:Console.WriteLine(" anda telah memilih volume balok");
                Console.Write("masukkan panjang balok: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("masukkan lebar balok: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Write("masukkan tinggi balok: ");
                int z = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("volume balok: " + (2 * ((x * y) + (x * z) + (y * z)))); break;
            }
        }
    }
}
