using System;

namespace Responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek taxi
            karyawan satu = new karyawan("Satu", "20113345", 2000000);
            karyawan dua = new karyawan("Dua", "20113329", 4000000);

            Console.WriteLine("===========================");
            Console.WriteLine("1. {0} {1} \t {2}", satu.Nama, satu.NIK, satu.Gaji);
            Console.WriteLine("2. {0} {1} \t {2}", dua.Nama, dua.NIK, dua.Gaji);

            Console.WriteLine ("Alhamdulillah Naik Gaji 10%");

            Console.WriteLine("===========================");
            Console.WriteLine("1. {0} {1} \t {2}", satu.Nama, satu.NIK, satu.Gaji2);
            Console.WriteLine("2. {0} {1} \t {2}", dua.Nama, dua.NIK, dua.Gaji2);
            




            Console.ReadKey();
        }
    }
}
