using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay08PR9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Rata-rata awal ");
            int meanAwal = int.Parse(Console.ReadLine());
            Console.Write("Rata-rata akhir ");
            int meanAkhir = int.Parse(Console.ReadLine());
            Console.Write("Ada tambahan berapa Anak? ");
            int banyakAnak = int.Parse(Console.ReadLine());
            Console.Write("Nilai anak tersebut? ");
            int nilaiAnak = int.Parse(Console.ReadLine());
            int jumlahKelas = banyakAnak * (nilaiAnak - meanAkhir) / (meanAkhir - meanAwal);
            Console.WriteLine(jumlahKelas);
            Console.ReadKey();
        }
    }
}
