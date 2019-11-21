using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay08PR11
{
    class Program
    {
        //NOMOR 11 SOAL BATCH215
        static void Main(string[] args)
        {
            int[, ] graf = new int[,] { {0, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                       {0, 0, 0, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                       {0, 0, 0, 0, 5, 5, 0, 0, 0, 5, 0, 0, 0, 0 },
                                       {0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0 },
                                       {0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0 },
                                       {0, 0, 0, 0, 0, 0, 5, 0, 5, 5, 0, 0, 0, 0 },
                                       {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0 },
                                       {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0 },
                                       {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0 },
                                       {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0 },
                                       {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 0 },
                                       {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5 },
                                       {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                       {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
            Program t = new Program();
            t.dijkstra(graf, 0);
            Console.ReadKey();
        }
        static int V = 14;
        int jarakMin(int[] jar, bool[] sptSet)
        {
            int min = int.MaxValue, min_index = -1;

            for (int i = 0; i < V; i++)
            { 
                if (sptSet[i] == false && jar[i] <= min)
                {
                min = jar[i];
                min_index = i;
                }
            }
        return min_index;
        }
        void printSolusi (int[] jar)
        {
            Console.Write("Jarak titik " + "dari titik awal\n");
            for (int i = 0; i < V; i++)
            {
                jar[i] = jar[i] - 5;
                Console.Write(i + " \t\t " + jar[i] + "\n");
            }
            Console.WriteLine();
            Console.WriteLine("Masakan pertama selesai dalam " + jar[12] + " menit");
            Console.WriteLine("Masakan kedua selesai dalam " + jar[13] + " menit");
        }
        void dijkstra(int[, ] graf, int src)
        {
            int[] jar = new int[V];
            bool[] sptSet = new bool[V];
            for (int i = 0; i < V; i++)
            {
                jar[i] = int.MaxValue;
                sptSet[i] = false;
            }
            jar[src] = 0;
            for (int count = 0; count < V-1; count++)
            {
                int u = jarakMin(jar, sptSet);
                sptSet[u] = true;
                for (int j = 0; j < V; j++)
                {
                    if (!sptSet[j] && graf[u, j] != 0 && jar[u] != int.MaxValue && jar[u] + graf[u, j] < jar[j])
                    {
                        jar[j] = jar[u] + graf[u, j];
                    }
                }
            }
            printSolusi(jar);
        }
    }
}
