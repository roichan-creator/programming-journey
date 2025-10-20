using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_5._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pilihan;

            do
            {
                Console.WriteLine("\n=== Menu Aplikasi ===");
                Console.WriteLine("1. Lihat Data");
                Console.WriteLine("2. Tambah Data");
                Console.WriteLine("3. Keluar");
                Console.Write("masukkan pilihan anda (1-3): ");
                if (!int.TryParse(Console.ReadLine(), out pilihan))
                {
                    Console.WriteLine("pilihan tidak valid. Harap masukkan angka 1, 2, atau 3.");
                    pilihan = 0;
                    continue;
                }
                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Anda memilih: Lihat data.");
                        break;
                    case 2:
                        Console.WriteLine("Anda memilih: Tambah Data.");
                        break;
                    case 3:
                        Console.WriteLine("Program akan berhenti...");
                        break;
                    default:
                    case 4:
                        Console.WriteLine("pilihan di luar jangkauan. Harap masukkan 1, 2, atau 3.");
                        break;
                }
            } while (pilihan != 3);
            Console.WriteLine("Terimakasih telah menggunakan aplikasi.");
        }
    }
}
