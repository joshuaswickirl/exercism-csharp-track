using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{
    private Dictionary<Allergen, bool> _allergies = new Dictionary<Allergen, bool>();

    public Allergies(int mask)
    {
        BitArray maskArray = new BitArray(new int[] { mask });
        int index = 0;
        foreach(Allergen allergen in Enum.GetValues(typeof(Allergen)))
        {
            _allergies[allergen] = maskArray.Get(index);
            index++;
        }
    }

    public bool IsAllergicTo(Allergen allergen) => _allergies[allergen];

    public Allergen[] List() => _allergies
                                    .Keys
                                    .Where(allergen => _allergies[allergen])
                                    .Cast<Allergen>()
                                    .ToArray();
}
