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
    private Dictionary<Allergen, bool> _allergyMask = new Dictionary<Allergen, bool>();

    public Allergies(int mask)
    {
        BitArray maskArray = new BitArray(new int[] { mask });
        int index = 0;
        foreach(Allergen allergen in Enum.GetValues(typeof(Allergen)))
        {
            _allergyMask[allergen] = maskArray.Get(index);
            index++;
        }
    }

    public bool IsAllergicTo(Allergen allergen) => _allergyMask[allergen];

    public Allergen[] List() => _allergyMask
                                    .Keys
                                    .Where(allergen => _allergyMask[allergen])
                                    .Cast<Allergen>()
                                    .ToArray();
}