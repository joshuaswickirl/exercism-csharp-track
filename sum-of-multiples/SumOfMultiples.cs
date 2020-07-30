using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> divisors, int max)
    {
        int sum = 0;
        HashSet<int> multiples = new HashSet<int>();
        for (int i = 1; i < max; i++)
        {
            foreach (var d in divisors)
            {
                if (d != 0 && !multiples.Contains(i) && i%d == 0)
                {
                    multiples.Add(i);
                    sum += i;
                }
            }
        }
        return sum;
    }
}