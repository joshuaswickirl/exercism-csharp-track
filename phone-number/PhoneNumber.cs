using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    private static string pattern = "[^0-9]";

    public static string Clean(string phoneNumber)
    {
        string cleanNumber = Regex.Replace(phoneNumber, pattern, "");
        if (isInvalidPhoneNumber(cleanNumber))
        {
            throw new System.ArgumentException();
        }
        return cleanNumber.Length == 11 ? cleanNumber.Substring(1) : cleanNumber;
    }

    private static bool isInvalidPhoneNumber(string number)
    {
        return number.Length < 10 
                || number.Length > 11 
                || (number.Length == 11 && number[0] != '1')
                || number[number.Length-10] < '2' 
                || number[number.Length-7] < '2';
    }
}
