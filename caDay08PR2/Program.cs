using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay08PR2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka berapapun : ");
            int angka = int.Parse(Console.ReadLine());
            int a = 0;

            for (int i = 1; i <= angka; i++)
            {
                if (angka % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine(angka + " termasuk angka prima");
            }
            else
            {
                Console.WriteLine(angka + " bukan angka prima");
            }
            Console.ReadKey();
        }
    }
}
