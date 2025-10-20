using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputuser = "";
            Console.WriteLine("Program akan terus berjalan hingga Anda mengetik 'keluar'.");
            while (inputuser.ToLower() != "keluar")
            {
                Console.Write("\nketik sesuatu (atau 'keluar' untuk berhenti): ");
                inputuser = Console.ReadLine();

                Console.WriteLine("Anda mengetik: " + inputuser);
            }
            Console.WriteLine("\nProgram selesai. Terima Kasih!");
        }
    }
}
