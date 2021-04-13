using System;

namespace Responsi
{
    class karyawan
    {
        //properties
        public string Nama { get; set; }
        public string NIK { get; set; }
        public int Gaji { get; set; }
        public int Gaji2 { get; set; }

        //method 
        public karyawan ( string nama, string nik, int gaji )
        {
            this.Nama = nama;
            this.NIK = nik;
            if (gaji < 0) {
                this.Gaji = 0;
                Gaji2 = Convert.ToInt32((Gaji * 1.1));
            }
            else {
                this.Gaji = gaji;
                Gaji2 = Convert.ToInt32 ((Gaji * 1.1));
            }
        }
    }

}