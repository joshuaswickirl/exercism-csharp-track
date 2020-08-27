using System;
using System.Collections.Generic;

public class GradeSchool
{
    private Dictionary<int, List<string>> roster = new Dictionary<int, List<string>>();

    public void Add(string student, int grade)
    {
        if (roster.ContainsKey(grade))
        {
            roster[grade].Add(student);
            roster[grade].Sort();
        }
        else
        {
            roster.Add(grade, new List<string>{student});
        }
    }

    public IEnumerable<string> Roster()
    {
        List<string> r = new List<string>();
        List<int> grades = new List<int>(roster.Keys);
        grades.Sort();
        foreach( int grade in grades )
        {
            r.AddRange(roster[grade]);
        }
        return r.ToArray();
    }

    public IEnumerable<string> Grade(int grade)
    {
        if (!roster.ContainsKey(grade))
        {
            return new String[0];
        }
        return roster[grade].ToArray();
    }
}