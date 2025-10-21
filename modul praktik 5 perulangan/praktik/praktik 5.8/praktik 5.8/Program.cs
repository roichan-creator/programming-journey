using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_5._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangipilihan;
           do
            {
                Console.WriteLine("----------------------");
                Console.Write("Masukkan nam anda: ");
                string nama = Console.ReadLine();
                Console.WriteLine($"Halo, {nama}! Proses telah selesai. ");
                // ------------------------------
                // pertanyaan mengulang
                Console.Write("Apakah anda ingin mengulang lagi? (ya/tidak): ");
                ulangipilihan = Console.ReadLine().ToLower();
                Console.WriteLine();
            } while (ulangipilihan == "ya");
            Console.WriteLine("terimakasih. program selesai");
        }
    }
}
