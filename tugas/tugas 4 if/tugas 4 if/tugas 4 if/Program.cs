using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_4_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan jam (0-23): ");
            int jam = int.Parse(Console.ReadLine()); 

            if (jam <= 5)
            {
                Console.WriteLine("selamat malam");
            }
            else if (jam <= 11)
            {
                Console.WriteLine("selamat pagi");
            }
            else if (jam <= 15)
            {
                Console.WriteLine("selamat siang");
            }
            else if (jam <= 18)
            {
                Console.WriteLine("selamat sore");
            }
            else if (jam <= 23)
            {
                Console.WriteLine("selamat malam");
            }
           
            else
            {
                Console.WriteLine("harga tiket: Rp 30.000(diskon lansia)");
            }
        }
    }
}
