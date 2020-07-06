using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64)
        {
            throw new ArgumentOutOfRangeException();
        }
        return (ulong)Math.Pow(2.0, n-1);
    }

    public static ulong Total()
    {
        ulong grains = 0;
        for (int n = 1; n <= 64; n++)
        {
            grains += Square(n);
        }
        return grains;
    }
}
