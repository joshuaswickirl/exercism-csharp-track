using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var total = new Dictionary<char, int> {
            ['A'] = 0, 
            ['T'] = 0, 
            ['G'] = 0, 
            ['C'] = 0
        };

        foreach (char character in sequence) {
            if (!total.ContainsKey(character)) {
                throw new System.ArgumentException("Sequence contains invalid nucleotide.");
            }
            
            total[character]++;
        }
        
        return total;
    }
}