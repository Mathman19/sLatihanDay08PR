using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay08PR4
{
    class Program
    {
        static void Main(string[] args)
        {

            int angka = int.Parse(Console.ReadLine());
            int range = 10 - angka;
            int tmpg = 0;

            for (int i = 1; i <= range; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (i < j)
                    {
                        tmpg++;
                    }
                }
            }
            Console.WriteLine(tmpg);
            Console.ReadKey();
        }
    }
}
