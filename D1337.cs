
// 1337. 矩阵中战斗力最弱的 K 行
// 题解：二分查找
// 对每一行进行一次二分查找 O(m(log n))，求出二元组[index, power]
// 快速随机选择选出k个最小元素/将二元组初始化堆，再取k个最小元素
namespace DailyExercise
{
    public class D1337
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            int[] ans = new int[k];
            int index = 0;
            int finalCol = mat[0].Length - 1;
            
            for (int row = 0; row < mat.Length; row++)
            {
                if (mat[row][0] == 0)
                {
                    ans[index] = row;
                    index += 1;
                    if (index == k)
                        return ans;
                }
            }
            
            for (int col = 1; col < mat[0].Length; col++)
            {
                for (int row = 0; row < mat.Length; row++)
                {
                    if (mat[row][col] == 0 && mat[row][col-1] == 1)
                    {
                        ans[index] = row;
                        index += 1;
                        if (index == k)
                            return ans;
                    }
                }
            }
            for (int row = 0; row < mat.Length; row++)
            {
                if (mat[row][finalCol] == 1)
                {
                    ans[index] = row;
                    index += 1;
                    if (index == k)
                        return ans;
                }
            }
            return ans;
        }
        
    }
}