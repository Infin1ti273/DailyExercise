
namespace DailyExercise.Daily_Cleared
{
    public class D457
    {
        // int safe = 1002;
        // int waiting = 1001;
        public bool CircularArrayLoop(int[] nums)
        {
            int n = nums.Length;
            for(int i = 0; i< n;++i)
            {
                if (nums[i] != 1002)
                    if (!Safe(nums,i,nums[i]))
                        return true;
            }
            return false;
        }

        bool Safe(int[] nums, int src, int val)
        {
            if (nums[src] > 1000)
                return nums[src] == 1002;

            //若该节点值反号，那么节点是安全的(但仍可以访问)
            if (nums[src] * val < 0)
            {
                return true;
            }
            
            int next = Next(src, nums[src], nums.Length);
            //若该节点指向自身，那么节点是安全的
            if (next == src)
            {
                nums[src] = 1002;
                return true;
            }
            
            //设置为"在迭代中“
            nums[src] = 1001;

            //如果下个节点安全，那么这个节点也安全
            if (Safe(nums, next, val))
            {
                nums[src] = 1002;
                return true;
            }

            return false;
        }

        int Next(int src, int val, int n)
        {
            int next = (src + val) % n;
            if (next < 0)
                next += n;
            return next;
        }
    
        
       
    }
}