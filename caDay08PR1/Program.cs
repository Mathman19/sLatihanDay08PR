using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay08PR1
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOMOR 1 SOAL BATCH215
            Console.Write("Masukkan nilai mahasiswa: ");
            int[] nilai = Array.ConvertAll(Console.ReadLine().Split(' '), x => Convert.ToInt32(x));
            int range = nilai.Length;
            int tmpg = 0;

            Console.WriteLine();
            int nilaiMax = nilai.Max();
            for (int i = range-1; i >= 0; i--)
            {
                if (nilaiMax == nilai[i])
                {
                    tmpg = tmpg + 1;
                }
            }
            Console.WriteLine("Nilai tertingginya yaitu {0}", nilaiMax);
            Console.Write("Ada {0} mahasiswa", tmpg);
            Console.ReadKey();
        }
    }
}
