using System;
using System.Linq;

// 743. 网络延迟时间
// 最短路径问题可以使用D算法
namespace DailyExercise.Daily_Failed
{
    
    public class D743
    {
        public int NetworkDelayTime(int[][] times, int n, int k)
        {
            const int INF = int.MaxValue / 2;
            int[,] table = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    table[i, j] = INF;
                }
            }

            foreach (int[] path in times)
            {
                table[path[0] - 1, path[1] -1 ] = path[2];
            }

            int[] dist = new int[n];
            bool[] used = new bool[n];
            Array.Fill(dist, INF);
            dist[k - 1] = 0;
            for (int i = 0; i < n; i++)
            {
                int min = INF+1;
                int x = -1;
                for (int j = 0; j < n; j++)
                {
                    if (!used[j] && dist[j] < min)
                    {       
                        min = dist[j];
                        x = j;
                    }
                }

                if (x == -1) continue;
                used[x] = true;
                for (int y = 0; y < n; ++y) {
                    dist[y] = Math.Min(dist[y], dist[x] + table[x, y]);
                }
            }
            return dist.Max()==INF?-1:dist.Max();
        }


    }
}