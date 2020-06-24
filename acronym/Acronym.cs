using System;
using System.Collections.Generic;

public static class Acronym
{
    private static char[] delimiters = {' ', '-', '_'};

    public static string Abbreviate(string phrase)
    {
        List<char> acronym = new List<char>();
        string[] tokens = phrase.Split(delimiters);
        foreach (string t in tokens)
        {
            if (t.Length != 0)
            {
                acronym.Add(t[0]);
            }
        }
        return string.Join("", acronym).ToUpper();
    }
}