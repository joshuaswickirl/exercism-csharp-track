using System;
using System.Collections.Generic;
public class Robot
{

    private static HashSet<string> _usedNames = new HashSet<string>();
    private string _name;
    private static string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public Robot() => _name = GenerateName();

    public string Name
    {
        get
        {
            return _name;
        }
    }

    public string GenerateName()
    {
        string newName = "";
        while (true) {
            newName = TwoLetters() + ThreeDigits();
            if (NameIsUnique(newName)) {
                break;
            }
        }
        _usedNames.Add(newName);
        return newName;
    }

    public void Reset()
    {
        if (_usedNames.Contains(_name)) {
            _usedNames.Remove(_name);
        }
        _name = GenerateName();
    }

    private string TwoLetters()
    {
        string letters = "";            
        for (int i = 0; i <= 1; i++)
        {
            letters += _chars[random.Next(_chars.Length)];
        }
        return letters;
    }

    private string ThreeDigits() => random.Next(100,1000).ToString();
    
    private bool NameIsUnique(string name) => _usedNames.Contains(name) ? false : true;

    private static Random random = new Random();
}
