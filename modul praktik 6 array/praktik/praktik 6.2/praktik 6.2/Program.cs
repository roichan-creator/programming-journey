﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] angka = new int[5];
            Console.Write("Masukkan nilai ke-1: ");
            angka[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai ke-2: ");
            angka[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai ke-3: ");
            angka[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai ke-4: ");
            angka[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai ke-5: ");
            angka[4] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nData yang Anda masukkan");
            Console.WriteLine("Nilai ke-1: " + angka[0]);
            Console.WriteLine("Nilai ke-2: " + angka[1]);
            Console.WriteLine("Nilai ke-3: " + angka[2]);
            Console.WriteLine("Nilai ke-4: " + angka[3]);
            Console.WriteLine("Nilai ke-5: " + angka[4]);
        }
    }
}
