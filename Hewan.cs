using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_OOP
{
    class Hewan
    {
        public string jenisHewan;
        public int tinggiRatarata;
        public int jumlahKaki;
        public string warnaKulit;

        //ini merupakan method yang tidak mengembalikan nilai
            public void TampilkanJenisHewan()
        {
            Console.WriteLine("Jenis Hewan: " + this.jenisHewan);
        }

        //ini merupakan method yang mengembalikan nilai
        public int DapatkanJumlahPasanganKaki()
        {
            int jumlahPasanganKaki = jumlahKaki / 2;
            return
                jumlahPasanganKaki;
        }
    }
}
