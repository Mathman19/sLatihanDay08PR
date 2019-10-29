using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay08PR7
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOMOR 7 SOAL BATCH215
            Console.Write("Kapan Paimin mulai tes? ");
            string dayPai = Console.ReadLine().ToLower();
            Console.Write("Berapa hari sekali Paimin tes? ");
            int rePai = int.Parse(Console.ReadLine()); Console.WriteLine();
            Console.Write("Kapan Paijo mulai tes? ");
            string dayPjo = Console.ReadLine().ToLower();
            Console.Write("Berapa hari sekali Paijo tes? ");
            int rePjo = int.Parse(Console.ReadLine()); Console.WriteLine();
            Console.Write("Kapan Fulan mulai tes? ");
            string dayFul = Console.ReadLine().ToLower();
            Console.Write("Berapa hari sekali Fulan tes? ");
            int reFul = int.Parse(Console.ReadLine()); Console.WriteLine();
            string[] day = { "senin", "selasa", "rabu", "kamis", "jumat", "sabtu", "minggu" };

            int kpk = 2*(rePai * rePjo * reFul);
            int[] pai = new int[kpk];
            pai[0] = hari(dayPai);
            int[] pjo = new int[kpk];
            pjo[0] = hari(dayPjo);
            int[] ful = new int[kpk];
            ful[0] = hari(dayFul);

            for (int i = 1; i < kpk; i++)
            {
                pai[i] = pai[i - 1] + rePai;
            }
            for (int i = 1; i < kpk; i++)
            {
                pjo[i] = pjo[i - 1] + rePjo;
            }
            for (int i = 1; i < kpk; i++)
            {
                ful[i] = ful[i - 1] + reFul;
            }
            for (int i = 1; i < kpk; i++)
            {
                for (int j = 1; j < kpk; j++)
                {
                    for (int k = 1; k < kpk; k++)
                    {
                        if (pai[i] == pjo[j] && pjo[j] == ful[k]) 
                        {
                            int n = pai[i] % 7;
                            Console.Write("mereka akan bertemu pada hari ");
                            Console.WriteLine(day[n].ToUpper() + " :)");
                            goto End;
                        }
                       
                    }
                    
                }
                
            }
            Console.WriteLine("Sayang sekali mereka gk bakal ketemu :(");
            End:
            Console.ReadKey();
        }
        static int hari(string day)
        {
            int dayInt = 0;
            switch (day)
            {
                case "senin":                    
                    dayInt = 0; break;
                case "selasa":                   
                    dayInt = 1; break;
                case "rabu":                   
                    dayInt = 2; break;
                case "kamis":                    
                    dayInt = 3; break;
                case "jumat":                    
                    dayInt = 4; break;
                case "sabtu":                    
                    dayInt = 5; break;
                case "minggu": 
                    dayInt = 6; break;
                default:
                    break;
            }
            return dayInt;
        }
    }
}
