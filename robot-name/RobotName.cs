using System;
using System.Collections.Generic;
public class Robot
{

    private static HashSet<string> usedNames = new HashSet<string>();

    private string name;

    public Robot()
    {
        name = GenerateName();
    }

    public string Name
    {
        get
        {
            return name;
        }
    }

    public string GenerateName()
    {
        string newName = "";
        bool uniqueName = false;
        
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        while (uniqueName == false) {
            newName = "";
            int numb = random.Next(100,1000);
            string letters = "";
            
            for (int i = 0; i <= 1; i++)
            {
                letters += chars[random.Next(chars.Length)];
            }
            
            newName = letters + numb.ToString(); 

            if (!usedNames.Contains(newName)) {
                break;
            }
        }

        usedNames.Add(newName);
        return newName;
    }

    public void Reset()
    {
        if (usedNames.Contains(name)) {
            usedNames.Remove(name);
        }
        name = GenerateName();
        
    }

    private static Random random = new Random();
}