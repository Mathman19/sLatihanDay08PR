using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay08PR3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] angka = new int[n + 2];
            angka[0] = 0;
            angka[1] = 1;
            for (int i = 1; i <= n; i++)
            {
                angka[i + 1] = angka[i] + angka[i - 1];
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write(angka[i] + "\t");
                    }
                    if (i % 2 == 0)
                    {
                        if (i % 4 == 2 && 2 * j == -i + 22)
                        {
                            Console.Write(angka[i] + "\t");
                            
                        }
                        if (i % 4 == 0 && 2 * j == i)
                        {
                            Console.Write(angka[i] + "\t");
                        }
                        else
                        {
                            Console.Write("\t");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
