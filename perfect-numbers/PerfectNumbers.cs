using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1 )
        {
            throw new ArgumentOutOfRangeException();
        }
        int sum = sumOfFactors(number);
        if (sum > number)
        {
            return Classification.Abundant;
        }
        if (sum < number || number == 1)
        {
            return Classification.Deficient;
        }
        return Classification.Perfect;
    }

    private static int sumOfFactors(int number)
    {
        HashSet<int> factors = new HashSet<int>(){ 1 };
        for (int i = (int)Math.Sqrt(number); i > 1; i--)
        {
            if (number % i == 0)
            {
                factors.Add(i);
                factors.Add(number / i);
            }
        }
        return factors.Sum();
    }
}
