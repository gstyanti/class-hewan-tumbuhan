using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Hewan buaya = new Hewan();

            buaya.jenisHewan = "Buaya Sungai";
            buaya.tinggiRatarata = 15;
            buaya.jumlahKaki = 4;
            buaya.warnaKulit = "coklat kehijauan";

            buaya.TampilkanJenisHewan();

            Console.WriteLine("Jumlah Pasang Kaki: " + buaya.DapatkanJumlahPasanganKaki());
            Console.WriteLine("Tinggi Rata-Rata: " + buaya.tinggiRatarata + "CM");
            Console.WriteLine("Warna Kulit: " + buaya.warnaKulit);
            Console.ReadKey();

            Tumbuhan kangkung = new Tumbuhan();

            kangkung.namaTumbuhan = "kangkung petik";
            kangkung.jenisAkar = "tunggang";

            kangkung.TampilkanNamaTumbuhan();

            Console.WriteLine("Nama Tumbuhan: " + NamaTumbuhan());
            Console.WriteLine("Jenis Akar Tumbuhan: ");

        }

       
    }
}
