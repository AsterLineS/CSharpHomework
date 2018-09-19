using System;

public class Ex1
{
    public static void Main(String[]args)
    {
        string s = "";
        Console.Write("Please input an int:");
        s = Console.ReadLine();
        int n = 0;
        n = int.Parse(s);

        Console.WriteLine(n+"的所有素数因子：");
        for(int i=2;i<=n;i++)
        {
            if (n % i == 0&&isPrime(i))
            {
                Console.Write(i + " ");
            }
        }
    }
    
  public static bool isPrime(int a)
    {
        if (a <= 1) return false;
        for(int i=2;i<a;i++)
        {
            if (a % i == 0) return false;
        }
        return true;
    }
}