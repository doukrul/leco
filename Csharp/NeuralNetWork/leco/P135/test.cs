public class Solution135 {
    public int Candy(int[] ratings) {
        int n = ratings.Length;
        int[]candy = new int[ratings.Length];

        // 初始化 candy 列表，每个孩子至少有一个糖果
        for (int i = 0; i < n; i++) {
            candy[i]=1;
        }

        // 第一次遍历：从左到右
        for (int i = 1; i < n; i++) {
            if (ratings[i] > ratings[i - 1]) {
                candy[i] = candy[i - 1] + 1;
            }
        }

        // 第二次遍历：从右到左
        for (int i = n - 2; i >= 0; i--) {
            if (ratings[i] > ratings[i + 1]) {
                candy[i] = Math.Max(candy[i], candy[i + 1] + 1);
            }
        }

        // 计算总糖果数
        int candies = 0;
        foreach (int can in candy) {
            candies += can;
        }

        return candies;
    }
}