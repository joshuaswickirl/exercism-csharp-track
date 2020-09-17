using System;
using System.Collections.Generic;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private static Dictionary<Schedule, int> _weekStart = new Dictionary<Schedule, int>()
    {
        {Schedule.First, 1}, {Schedule.Second, 8}, {Schedule.Third, 15}, {Schedule.Fourth, 22}
    };

    private int _month;
    private int _year;

    public Meetup(int month, int year)
    {
        _month = month;
        _year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        switch(schedule)
        {
            case Schedule.First:
            case Schedule.Second:
            case Schedule.Third:
            case Schedule.Fourth:
                return nth(dayOfWeek, schedule);
            case Schedule.Last:
                return last(dayOfWeek);
            case Schedule.Teenth:
                return teenth(dayOfWeek);
            default:
                throw new ArgumentException("Unknown schedule value.");
        }
    }

    private DateTime nth(DayOfWeek dow, Schedule week)
    {
        DateTime dt = new DateTime(_year, _month, _weekStart[week]);
        for (int d = 1; d <= 7; d++)
        {
            if (dt.DayOfWeek == dow)
            {
                break;
            }
            dt = dt.AddDays(1);
        }
        return dt;
    }

    private DateTime last(DayOfWeek dow)
    {
        int daysInMonth = DateTime.DaysInMonth(_year, _month);
        DateTime dt = new DateTime(_year, _month, daysInMonth);
        for (int d = 7; d >= 1; d--)
        {
            if (dt.DayOfWeek == dow)
            {
                break;
            }
            dt = dt.AddDays(-1);
        }
        return dt;
    }

    private DateTime teenth(DayOfWeek dow)
    {
        DateTime dt = new DateTime(_year, _month, 13);
        for (int d = 1; d <= 7; d++)
        {
            if (dt.DayOfWeek == dow)
            {
                break;
            }
            dt = dt.AddDays(1);
        }
        return dt;
    }
}