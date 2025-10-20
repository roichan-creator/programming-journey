using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik__konversi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== program operator konversi suhu ===");

            Console.Write("masukkan suhu dalam celcius: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("=== hasil konversi ===");
            Console.WriteLine($"celcius   = " + c + " " + "°C");
            double F = (c * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit= " + F + " " + "°F");
            double R = (c * 4 / 5);
            Console.WriteLine("Reamur    = " + R + " " + "°Re");


        }
    }
}
