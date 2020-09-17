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
                return findDatetime(dayOfWeek, _weekStart[schedule]);
            case Schedule.Last:
                int daysInMonth = DateTime.DaysInMonth(_year, _month);
                return findDatetime(dayOfWeek, daysInMonth-6);
            case Schedule.Teenth:
                return findDatetime(dayOfWeek, 13);
            default:
                throw new ArgumentException("Unknown schedule value.");
        }
    }

    private DateTime findDatetime(DayOfWeek dow, int startDate)
    {
        DateTime dt = new DateTime(_year, _month, startDate);
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