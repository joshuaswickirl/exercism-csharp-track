using System;
using System.Linq;
using System.Collections.Generic;

public static class Acronym
{
    private static char[] delimiters = {' ', '-', '_'};

    public static string Abbreviate(string phrase)
    {
        List<char> acronym = new List<char>();
        string[] tokens = phrase.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        foreach (string t in tokens)
        {
            acronym.Add(t[0]);
        }
        return string.Join("", acronym).ToUpper();
    }
}