using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> scores;
    
    public HighScores(List<int> list) => scores = list;

    public List<int> Scores() => scores;
    
    public int Latest() => scores.Last();
    
    public int PersonalBest() => scores.Max();
    
    public List<int> PersonalTopThree()
    {
        scores.Sort();
        return Enumerable.Reverse(scores).Take(3).ToList();
    }
}