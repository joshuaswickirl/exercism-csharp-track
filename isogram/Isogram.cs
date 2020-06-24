using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        HashSet<char> usedLetters = new HashSet<char>();
        foreach (char c in word.ToLower())
        {
            if (charIsNotLetter(c))
            {
                continue;
            }
            if (usedLetters.Contains(c))
            {
                return false;
            }
            usedLetters.Add(c);
        }
        return true;
    }

    private static bool charIsNotLetter(char c) => !Char.IsLetter(c);
}
