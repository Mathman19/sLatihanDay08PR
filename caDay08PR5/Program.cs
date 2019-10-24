using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay08PR5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka pertama: ");
            int angka1 = int.Parse(Console.ReadLine());
            Console.Write("Masukkan angka kedua: ");
            int angka2 = int.Parse(Console.ReadLine());
            

            if (angka1 < angka2)
            {
                habisBagi(angka1, angka2);
            }
            else
            {
                habisBagi(angka2, angka1);
            }
            
        }
        static void habisBagi(int a, int b)
        {
            int tmp1 = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    tmp1 += 1;
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Ada {0} angka", tmp1);
            Console.ReadKey();
        }
    }
}
