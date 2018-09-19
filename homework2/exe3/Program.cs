using System;

public class Exe3
{
    public static void Main(String[]args)
    {
        int N = 100;
        bool[] numbers = new bool[N+1];
        for (int i = 0; i <= N; i++) numbers[i] = true;

        for(int i = 2; i <= N; i++)
        {
            for(int j=2*i;j<=N;j+=i)
            {
                numbers[j] = false;
            }
        }
        for(int i=2;i<=N;i++)
        {
            if (numbers[i]) Console.Write(i+" ");
        }
    }
}
