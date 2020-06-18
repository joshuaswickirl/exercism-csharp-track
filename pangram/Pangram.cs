using System;
using System.Collections.Generic;


public static class Pangram
{
    private const int numLettersInAlphabet = 26;

    public static bool IsPangram(string input)
    {
        HashSet<char> usedLetters = new HashSet<char>();
        foreach (char c in input.ToLower())
        {
            if (Char.IsLetter(c))
            {
                usedLetters.Add(c);
            } 
        }
        return usedLetters.Count == numLettersInAlphabet;
    }
}
