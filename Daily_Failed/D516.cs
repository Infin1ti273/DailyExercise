using System;

namespace DailyExercise.Daily_Failed
{
    //516. 最长回文子序列（动态规划）
    public class D516
    {
        public int LongestPalindromeSubseq(string s)
        {
            int n = s.Length;
            int[,] subSeq = new int[n,n];
            subSeq[0, 0] = 1;
            for (int j = 1; j < n; j++)
            {
                subSeq[j, j] = 1;
                for (int i = j - 1; i >= 0; i--)
                {
                    if (s[i] == s[j])
                        subSeq[i, j] = subSeq[i + 1, j - 1] + 2;
                    else
                        subSeq[i, j] = Math.Max(subSeq[i + 1, j], subSeq[i, j - 1]);
                }
            }
            return subSeq[0,n-1];
        }
    }
}