using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay08PR10
{
    class Program
    {
        static void Main(string[] args)
        {
            int uang = int.Parse(Console.ReadLine());
            int tmpg, uang1, uang2, uang3, uang4;

            uang1 = uang / 100;
            tmpg = uang % 100;
            uang2 = tmpg / 50;
            tmpg = tmpg % 50;
            uang3 = tmpg / 20;
            tmpg = tmpg / 20;
            uang4 = tmpg / 10;
            tmpg = tmpg % 10;

            Console.WriteLine(uang1 + uang2 + uang3 + uang4);
            Console.ReadKey();
        }
    }
}
