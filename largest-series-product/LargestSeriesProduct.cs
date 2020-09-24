using System;
using System.Text.RegularExpressions;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        if (span == 0)
        {
            return 1;
        }
        if (isNotNumeric(digits) || span > digits.Length || span < 0)
        {
            throw new ArgumentException("Digits must be numerical and of greater length than span.");
        }

        long biggest = getProduct(digits.Substring(0, span));
        for (int i = 1; i <= digits.Length - span; i++)
        {
            long next = getProduct(digits.Substring(i, span));
            if (next > biggest)
            {
                biggest = next;
            }
        }
        return biggest;
    }

    private static long getProduct(string slice)
    {
        long product = (int)Char.GetNumericValue(slice[0]);
        for (int i = 1; i < slice.Length; i++)
        {
            product = product * (int)Char.GetNumericValue(slice[i]);
        }
        return product;
    }

    private static bool isNotNumeric(string digits)
    {
        Regex rx = new Regex(@"^\d+$", RegexOptions.Compiled);
        return !rx.IsMatch(digits);
    }
}