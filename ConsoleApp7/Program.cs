using System;
class test
{
    public static void Main()
    {
        Console.WriteLine("enter your age");
        string a = Console.ReadLine();
        int x = Convert.ToInt32(a);
        Console.Write(sal(x));
        Console.Write("/");
        Console.Write(mah(x));
        Console.Write("/");
        Console.Write(hafte(x));
        Console.Write("/");
        Console.WriteLine(x);
        Console.Write(sal(x));
        Console.Write("/");
        int y = x - (int)sal(x) * 360;
        Console.Write(mah(y));
        Console.Write("/");
        int z = y - (int)mah(y) * 30;
        Console.Write(hafte(z));
        Console.Write("/");
        int w = z - (int)hafte(z) * 7;
        Console.Write(w);
    }
    private static double sal(int x)
    {
        return (int)(x / 360);
    }
    private static double mah(int x)
    {
        return (int)(x/30);
    }
    private static double hafte(int x)
    {
        return (int)(x / 7);
    }
}