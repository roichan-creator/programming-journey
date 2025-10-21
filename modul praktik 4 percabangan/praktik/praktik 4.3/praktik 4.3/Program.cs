using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai ujian: ");
            int nilai = int.Parse(Console.ReadLine());
            if (nilai >= 75)
                Console.WriteLine("selmaat, Anda Lulus!");
        }
    }
}
