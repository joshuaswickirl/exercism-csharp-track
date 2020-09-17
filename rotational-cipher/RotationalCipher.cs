using System;

public static class RotationalCipher
{
    private static ushort alphabetLength = 26;

    public static string Rotate(string text, int shiftKey)
    {
        char[] cipher = new char[text.Length];
        for(int i = 0; i < text.Length; i++)
        {
            char p = text[i];
            if(Char.IsLetter(p))
            {
                cipher[i] = shiftChar(p, shiftKey);
            }
            else
            {
                cipher[i] = p;
            }
        }
        return new string(cipher);
    }

    private static char shiftChar(char p, int shiftKey)
    {
        ushort c = (ushort)(Convert.ToUInt16(p) + shiftKey);
        if((Char.IsLower(p) && c > 'z') || (Char.IsUpper(p) && c > 'Z'))
        {
                c -= alphabetLength;
        }
        return (char)c;
    }
}
