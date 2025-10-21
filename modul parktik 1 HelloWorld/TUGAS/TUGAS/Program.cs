using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INPUT BIODATA SISWA===");
            Console.Write("NAMA LENGKAP   : ");
            string nl = Console.ReadLine();
            Console.Write("NAMA PANGGILAN : ");
            string np = Console.ReadLine();
            Console.Write("JENIS KELAMIN  : ");
            string jk = Console.ReadLine();
            Console.Write("AGAMA          : ");
            string agama = Console.ReadLine();
            Console.Write("UMUR           : ");
            string umur = Console.ReadLine();
            Console.Write("KELAS          : ");
            string kls = Console.ReadLine();
            Console.Write("JURUSAN        : ");
            string jur = Console.ReadLine();
            Console.Write("ALAMAT         : ");
            string alamat = Console.ReadLine();
            Console.Write("HOBI           : ");
            string hobi = Console.ReadLine();
            Console.Write("CITA-CITA      : ");
            string cita = Console.ReadLine();
            Console.WriteLine("=======================");
            Console.WriteLine("=== BIODATA SISWA ===");
            Console.WriteLine($"Nama Lengkap    : {nl}");
            Console.WriteLine($"Nama Panggilan  : {np}");
            Console.WriteLine($"Jenis Kelamin   : {jk}");
            Console.WriteLine($"Agama           : {agama}");
            Console.WriteLine($"Umur            : {umur}");
            Console.WriteLine($"Kelas           : {kls}");
            Console.WriteLine($"Jurusan         : {jur}");
            Console.WriteLine($"Alamat          : {alamat}");
            Console.WriteLine($"Hobi            : {hobi}");
            Console.WriteLine($"Cita-cita       : {cita}");
            Console.WriteLine("=======================");
        }
    }
}
