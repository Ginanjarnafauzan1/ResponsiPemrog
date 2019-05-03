using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2258
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kry1 = new Karyawan();

            kry1.Nama = "Ginanjar";
            kry1.Nik = "18.11.2258";
            kry1.GajiBulanan = 5000000;

            Karyawan kry2 = new Karyawan();

            kry2.Nama = "Nafauzan";
            kry2.Nik = "18.11.2256";
            kry2.GajiBulanan = 4500000;

            Console.WriteLine("no.\tNik/Nama\t\tGajiBulanan");
            Console.WriteLine("============================");
            Console.WriteLine("1.\t{0}  {1}\t\t{2}", kry1.Nik, kry1.Nama, kry1.GajiBulanan);
            Console.WriteLine("2.\t{0}  {1}\t\t{2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan);

            Console.WriteLine("\n\n");
            Console.WriteLine("Gaji Naik 10%");
            Console.WriteLine("\n");
            Console.WriteLine("no.\tNik/Nama\t\tGajiBulanan");
            Console.WriteLine("=============================");
            Console.WriteLine("1.\t{0}  {1}\t\t{2}", kry1.Nik, kry1.Nama, kry1.GajiBulanan + (kry1.GajiBulanan * 0.10));
            Console.WriteLine("2.\t{0}  {1}\t\t{2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan + (kry2.GajiBulanan * 0.10));
            Console.ReadKey();
        }
    }
}
