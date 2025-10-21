using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_konversi_uang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== program operator konversi suhu ===");

            Console.Write("masukkan jumlah uang dalam rupiah (IDR):");
            double rp = Convert.ToDouble(Console.ReadLine());

            double usd = rp / 16_668;
            double gbp = rp / 22_386.99;
            double jpy = rp / 112.08;
            double sar = rp / 4_444.44;
            Console.WriteLine("=== hasil konversi ===");
            Console.WriteLine("dolar amerika : $" + usd);
            Console.WriteLine("poundsterling : £" + gbp);
            Console.WriteLine("yen jepang    : ¥" + jpy);
            Console.WriteLine("riyal saudi   : ﷼" + sar);
        }
    }
}
