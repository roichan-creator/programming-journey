using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM PEMBAYARAN BIOSKOP");
            Console.WriteLine("Pilih Jenis Film: ");
            Console.WriteLine("1. Horor");
            Console.WriteLine("2. Romantic");
            Console.Write("Masukkan Pilihan (1/2): ");
            int jenis = int.Parse(Console.ReadLine());
            int harga = 0;
            string judul = "";

            if (jenis == 1)
            {
                Console.WriteLine("\n--- Daftar Film Horor ---");
                Console.WriteLine("1. Kang Solah from Kang Mak x Nenek Gayung\tRp 30000");
                Console.WriteLine("2. Death Whisperer 3\tRp 35000");
                Console.WriteLine("3. Rest Area\t\tRp 40000");
                Console.Write("Pilih nomor Film: ");
                int pilih = int.Parse(Console.ReadLine());

                if (pilih == 1)
                {
                    judul = "Kang Solah from Kang Mak x Nenek Gayung";
                    harga = 30000;
                }
                else if (pilih == 2)
                {
                    judul = "Death Whisperer 3";
                    harga = 35000;
                }
                else if (pilih == 3)
                {
                    judul = "Rest Area";
                    harga = 40000;
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid");
                    return;
                }
            }
            else if (jenis == 2)
            {
                Console.WriteLine("\n--- Daftar Film Horor ---");
                Console.WriteLine("1. The Architecture of love\tRp 30000");
                Console.WriteLine("2. Sampai Nanti, Hanna!\t          Rp 35000");
                Console.WriteLine("3. Love for Sale\t\t               Rp 40000");
                Console.Write("Pilih nomor Film: ");
                int pilih = int.Parse(Console.ReadLine());

                if (pilih == 1)
                {
                    judul = "The Architecture of love";
                    harga = 30000;
                }
                else if (pilih == 2)
                {
                    judul = "Sampai Nanti, Hanna";
                    harga = 35000;
                }
                else if (pilih == 3)
                {
                    judul = "Love for Sale";
                    harga = 40000;
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid");
                return;
            }

            Console.WriteLine("\n========================");
            Console.WriteLine("judul film\t: " + judul);
            Console.WriteLine("harga tiket\t: Rp " + harga);
            Console.WriteLine("\n========================");
            Console.WriteLine("terima kasih telah membeli tiket!");
        }
    }
}