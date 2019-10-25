using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay08PR6
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = 8 * 7 * 5;
            int[] tamu1 = new int[range];
            int[] tamu2 = new int[range];
            int[] tamu3 = new int[range];

            for (int i = 0; i < range; i++)
            {
                tamu1[i] = 6 + i * 8;
            }
            for (int i = 0; i < range; i++)
            {
                tamu2[i] = 5 + i * 7;
            }
            for (int i = 0; i < range; i++)
            {
                tamu3[i] = 2 + i * 5;
            }
            for (int i = 0; i < range; i++)
            {
                for (int j = 0; j < range; j++)
                {
                    for (int k = 0; k < range; k++)
                    {
                        if (tamu1[i] == tamu2[j] && tamu2[j] == tamu3[k])
                        {
                            Console.WriteLine(tamu1[i]);
                            goto End;
                        }
                    }
                }
            }
            End:
            Console.ReadKey();
        }
    }
}
