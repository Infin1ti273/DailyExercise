using System.Collections.Generic;

namespace DailyExercise.Daily_Failed
{
    //446.等差数列划分Ⅱ-子序列
    public class D446
    {
        public int NumberOfArithmeticSlices(int[] nums)
        {
            int ans = 0;
            int n = nums.Length;
            //设置一个长为N的哈希数组[最后项]<增量,等差子序列>
            Dictionary<long, int>[] h = new Dictionary<long, int>[n];
            for (int i = 0; i < n; i++) h[i] = new Dictionary<long, int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    //遍历所有可能(i, j)和差值
                    long d = 1L * nums[i] - nums[j];
                    
                    //前端是另一序列的尾端：第n次拼接:ans+n
                    int cnt = h[j].ContainsKey(d) ? h[j][d] : 0;
                    ans += cnt;
                    
                    //未记录：记为1个子序列；已记录：子序列+1
                    if (h[i].ContainsKey(d))
                        h[i][d] += cnt + 1;
                    else
                        h[i].Add(d, cnt+1);
                    
                }
            }

            return ans;
        }
    }
}