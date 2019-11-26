using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay08PR12
{
    class Program
    {
        static void Main(string[] args)
        {
            int banyak = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int range = str.Length;
            char[] huruf = str.ToCharArray();
            int[] back = new int[banyak+2];
            int tmpg = 0;

            for (int i = 0; i < range; i++)
            {
                if (huruf[i] == 'A')
                {
                    tmpg++;
                }                
            }

            int range1 = range + tmpg;
            back[0] = range;
            back[1] = range1;

            for (int i = 1; i <= banyak; i++)
            {
                back[i + 1] = back[i] + back[i - 1];
            }
            Console.WriteLine("\nPanjang string adalah {0}", back[banyak]);
            Console.ReadKey();
        }
    }
}
