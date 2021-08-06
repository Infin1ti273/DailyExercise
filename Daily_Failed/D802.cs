using System.Collections.Generic;

//802.找到最终的安全状态
//深度优先搜索+三色标记法(0未访问/1递归中/2安全节点)
namespace DailyExercise.Daily_Failed
{
    public class D802
    {
        public IList<int> EventualSafeNodes(int[][] graph)
        {
            int[] color = new int[graph.Length];
            IList<int> ans = new List<int>();
            for (int i = 0; i < graph.Length; ++i)
            {
                if (Safe(graph, color, i))
                    ans.Add(i);
            }

            return ans;
        }

        bool Safe(int[][] graph, int[] color, int src)
        {
            if (color[src] > 0) {
                return color[src] == 2;
            }

            color[src] = 1;
            foreach (int dest in graph[src])
            {
                if (!Safe(graph, color, dest))
                    return false;
            }

            color[src] = 2;
            return true;
        }
        // int Dfs(int src, int pivot, IList<int[]> record)
        // {
        //     if (_graph[src].Length == 0 || _graph[src].Length == pivot) return 0;
        //     
        //     int dest = _graph[src][pivot];
        //     int[] path = {src, dest};
        //     foreach (int[] r in record)
        //     {
        //         if (r == path)
        //             return 1;
        //     }
        //     record.Add(path);
        //
        //     
        //     return Dfs(dest, 0, record) + Dfs(src, ++pivot, record);
        // }
    }
}