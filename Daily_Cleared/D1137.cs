namespace DailyExercise.Daily_Cleared
{
    //1137. 泰波那契（太菜不看）
    public class D1137
    {
        public int Tribonacci(int n) {
            switch (n)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                case 2:
                    return 1;
            }

            int[] array = {0,1,1,2};
            int ans = 2;
            for (int i = 3; i <= n; i++)
            {
                switch (i % 4)
                {
                    case 0:
                    {
                        ans = array[1] + array[2] + array[3];
                        array[0] = ans;
                        break;
                    }
                    case 1:
                    {
                        ans = array[0] + array[2] + array[3];
                        array[1] = ans;
                        break;
                    }
                    case 2:
                    {
                        ans = array[0] + array[1] + array[3];
                        array[2] = ans;
                        break;
                    }
                    case 3:
                    {
                        ans = array[0] + array[1] + array[2];
                        array[3] = ans;
                        break;
                    }
                }
            }
            return ans;
        }
    }
}