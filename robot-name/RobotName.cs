using System;
using System.Collections.Generic;
public class Robot
{

    private static HashSet<string> _usedNames = new HashSet<string>();
    private string _name;
    private static int _asciiA = 65;
    private static int _asciiZ = 90;
    private static int _between100 = 100;
    private static int _and1000 = 1000;

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
            letters += Convert.ToChar(random.Next(_asciiA,_asciiZ));
        }
        return letters;
    }

    private string ThreeDigits() => random.Next(_between100,_and1000).ToString();
    
    private bool NameIsUnique(string name) => _usedNames.Contains(name) ? false : true;

    private static Random random = new Random();
}
