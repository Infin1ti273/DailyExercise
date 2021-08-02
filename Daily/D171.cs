namespace DailyExercise.Daily
{
    // 171. Excel表列序号
    public class D171
    {
        public int TitleToNumber(string columnTitle)
        {
            int multiply = 1;
            int ans = 0;
            for (int i = columnTitle.Length - 1; i >= 0; i--)
            {
                ans += (columnTitle[i] - 64) * multiply;
                multiply *= 26;
            }
            return ans;
        }
    }
    
    // const int asc = 'A' - 64;
}