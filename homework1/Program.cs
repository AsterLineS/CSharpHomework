using System;

public class AddNum
{
    public static void Main(string[] args)
    {
        string s1 = "";
        string s2 = "";
        int a = 0;
        int b = 0;
        Console.Write("Please input int a:");
        s1 = Console.ReadLine();
        a = int.Parse(s1);
        Console.Write("Please input int b:");
        s2 = Console.ReadLine();
        b= int.Parse(s2);
        Console.WriteLine(a+"*"+b+"="+a*b);
    }
}

