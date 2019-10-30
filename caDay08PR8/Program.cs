using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay08PR8
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmpg = 0;
            int tmp = 0;
            int[] b = new int[13];
            for (int k = 0; k < b.Length; k++)
            {
                b[k] = 3 + (k + 1) * 7;
            }
            for (int i = 100; i > 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        tmp++;
                    }
                }
                for (int l = 0; l < 13; l++)
                {
                    if (tmp == 2 && b[l]==i)
                    {
                        tmpg++;
                        Console.Write(i + "\t");
                    }
                }
                tmp = 0;
            }
            Console.WriteLine();
            Console.WriteLine("Ada {0} angka",tmpg);
            Console.ReadKey();
        }
    }
}
