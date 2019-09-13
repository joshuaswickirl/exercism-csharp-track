using System;
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

        for (int i=0; i < sequence.Length; i++) {
            if (!total.ContainsKey(sequence[i])) {
                throw new System.ArgumentException("Sequence contains invalid nucleotide(s)");
            }
            
            total[sequence[i]]++;
        }
        
        return total;
    }
}