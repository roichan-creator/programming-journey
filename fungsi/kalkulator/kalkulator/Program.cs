using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hitunglagi;
            do
            {
                Console.Clear();
                Console.WriteLine("--- KALKULATOR SEDERHANA ---");

                TampilkanMenu();

                Console.Write("masukkan pilihan operasi (1-4): ");
                string pilihan = Console.ReadLine();

                double angka1, angka2, hasil = 0;
                if (AmbilInputAngka(out angka1, out angka2))
                {
                    switch (pilihan)
                    {
                        case "1":
                            hasil = Tambah(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} + {angka2} = {hasil}");
                            break;
                        case "2":
                            hasil = Kurang(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} - {angka2} = {hasil}");
                            break;
                        case "3":
                            hasil = Kali(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} * {angka2} = {hasil}");
                            break;
                        case "4":
                            if (angka2 == 0)
                            {
                                Console.WriteLine("\nError: Tidak dapat melakukan pembagian dengan nol.");
                            }
                            else
                            {
                                hasil = Bagi(angka1, angka2);
                                Console.WriteLine($"\nHasil: {angka1} // {angka2} = {hasil}");
                            }
                            break;
                        default:
                            Console.WriteLine("\nPilihan yang Anda masukkan tidak valid");
                            break;
                    }
                }
                Console.Write("\nApakah Anda ingin menghitung kembali (y/n): ");
                hitunglagi = Console.ReadLine();
            }while (hitunglagi.ToLower() == "y");
            Console.WriteLine("\nTerimakasih telah menggunakan kalkulator ini. " + "Tekan tombol apa saja untuk keluar.");
            Console.ReadKey();
        }
        
        static void TampilkanMenu()
        {
            Console.WriteLine("Pilih operasi matematika:");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
        }
        static bool AmbilInputAngka(out double angka1, out double angka2)
        {
            Console.Write("Masukkan angka pertama: ");
            if (!double.TryParse(Console.ReadLine(), out angka1))
            {
                Console.WriteLine("Input untuk angka kedua tidak valid.");
                angka2 = 0;
                return false;
            }

            Console.Write("Masukkan angka kedua: ");
            if (!double.TryParse(Console.ReadLine(), out angka2))
            {
                Console.WriteLine("Input untuk angka kedua tidak valid.");
                return false;
            }
            return true;
        }
        static double Tambah(double a, double b) 
        { 
            return a + b;
        }
        static double Kurang(double a, double b)
        {
            return a - b;
        }
        static double Kali(double a, double b)
        {
            return a * b;
        }
        static double Bagi(double a, double b)
        {
            return a / b;
        }
    }
}
