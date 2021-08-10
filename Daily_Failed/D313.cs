using System;

namespace DailyExercise.Daily_Failed
{
    //313. 超级丑数
    public class D313
    {
        public int NthSuperUglyNumber(int n, int[] primes)
        {

            int[] ans = new int[n+1];
            ans[1] = 1;
            //下一个超级丑数是ans[ptrs[i]]*primes[i]
            int[] ptrs = new int[primes.Length];
            Array.Fill(ptrs, 1);

            if (n == 1)
                return 1;

            int[] tmp = new int[primes.Length];
            for (int i = 2; i <= n; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < primes.Length; j++)
                {
                    tmp[j] = ans[ptrs[j]] * primes[j];
                    min = Math.Min(min, tmp[j]);
                }

                ans[i] = min;
                for (int j = 0; j < primes.Length; j++)
                {
                    if (min == tmp[j])
                        ptrs[j] += 1;
                }
            }

            return ans[n];
        }
    }
}