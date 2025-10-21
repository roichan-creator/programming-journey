using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program untuk mengetahui karakter yang diinputkan,
            //apakah huruf besar, huruf kecil, spasi, digit atau yang lainnya
            Console.Write("Masukkan Karakter : ");
            char karakter = Console.ReadKey().KeyChar; //membaca 1 karakter
            Console.WriteLine(); // Pindah baris

            if (char.IsUpper(karakter))
            {
                Console.WriteLine("karaker yang diinputkan adalah huruf besar.");
            }
            else if (char.IsLower(karakter))
            {
                Console.WriteLine("karaker yang diinputkan adalah huruf kecil.");
            }
            else if (char.IsWhiteSpace(karakter))
            {
                Console.WriteLine("karaker yang diinputkan adalah spasi.");
            }
            else if (char.IsDigit(karakter))
            {
                Console.WriteLine("karaker yang diinputkan adalah digit(angka).");
            }
            else
            {
                Console.WriteLine("karaker yang diinputkan adalah karakter lainnya (simbol).");
            }
        }
    }
}
