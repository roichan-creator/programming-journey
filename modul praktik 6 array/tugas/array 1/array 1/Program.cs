using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nama = new string[3];
            char[] jk = new char[3];
            string[] kls = new string[3];

            Console.Write("Masukkan Nama siswa ke-1: ");
            nama[0] = Console.ReadLine();
            Console.Write("Masukkan jenis kelamin (L/P): ");
            jk[0] = char.Parse(Console.ReadLine());
            Console.Write("Masukkan kelas: ");
            kls[0] = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Masukkan Nama siswa ke-2: ");
            nama[1] = Console.ReadLine();
            Console.Write("Masukkan jenis kelamin (L/P): ");
            jk[1] = char.Parse(Console.ReadLine());
            Console.Write("Masukkan kelas: ");
            kls[1] = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Masukkan Nama siswa ke-3: ");
            nama[2] = Console.ReadLine();
            Console.Write("Masukkan jenis kelamin (L/P): ");
            jk[2] = char.Parse(Console.ReadLine());
            Console.Write("Masukkan kelas: ");
            kls[2] = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("==== Data Siswa ====");
            Console.WriteLine("Nama: " + nama[0] + " | JK: " + jk[0] + " | Kelas: " + kls[0]);
            Console.WriteLine("Nama: " + nama[1] + " | JK: " + jk[1] + " | Kelas: " + kls[1]);
            Console.WriteLine("Nama: " + nama[2] + " | JK: " + jk[2] + " | Kelas: " + kls[2]);
        }
    }
}
