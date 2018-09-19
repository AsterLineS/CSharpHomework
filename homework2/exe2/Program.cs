using System;

public class Exe2
{
    public static void Main(String[]args)
    {
        int[] numbers = new int[5] { 2, 5, 3, 1, 4 };
        int sum = 0;
        int max = numbers[0];
        int min = numbers[0];
        for(int i=0;i<5;i++)
        {
            sum += numbers[i];
            if (max < numbers[i]) max = numbers[i];
            if (min > numbers[i]) min = numbers[i];
        }
        Console.WriteLine("最大值：" + max);
        Console.WriteLine("最小值：" + min);
        Console.WriteLine("总和：" + max);
        Console.WriteLine("平均值：" + ((double)sum/5));
    }
}