using System;

public static class ResistorColor
{
    private readonly static string[] colors = {
        "black", 
        "brown", 
        "red", 
        "orange", 
        "yellow", 
        "green", 
        "blue", 
        "violet", 
        "grey", 
        "white",
    };

    public static int ColorCode(string color)
    {
        return Array.IndexOf(colors,color);
    }

    public static string[] Colors()
    {   
        string[] colorsCopy = new string[colors.Length];
        Array.Copy(colors, colorsCopy, colors.Length);
        return colorsCopy;
    }
}