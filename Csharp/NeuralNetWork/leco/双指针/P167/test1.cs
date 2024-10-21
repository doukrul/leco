public class SolutionP167test1
{

    public int[] TwoSum(int[] numbers, int target)
    {
        int i1 = 0, i2 = numbers.Length - 1;
        while (i1 < i2)
        {
            int sum = numbers[i1] + numbers[i2];
            if (sum == target)
            {
                return new int[2] { i1 + 1, i2 + 1 };
            }
            if (sum > target)
            {
                --i2;
            }
            else
            {
                ++i1;
            }
        }
        return new int[2] { 0, 0 };

    }
}
