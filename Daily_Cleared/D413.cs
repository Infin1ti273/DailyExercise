
namespace DailyExercise.Daily_Cleared
{
    // 413.等差数列划分
    public class D413
    {
        public int NumberOfArithmeticSlices(int[] nums)
        {
            int n = nums.Length;
            int ans = 0;
            int ptr = 0;
            if (n==1)
            {
                return 0;
            }
            int variance = nums[ptr + 1] - nums[ptr];
            for (int i = 1; i < n;i++)
            {
                if (i-ptr<2)
                    continue;
                if ((i-ptr)*variance==(nums[i]-nums[ptr]))
                {
                    ans += (i - ptr - 1);
                }
                else
                {
                    ptr = i - 1;
                    variance = nums[ptr + 1] - nums[ptr];
                }
            }
            return ans;
        }
        
    }
}