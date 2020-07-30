using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {   
        int steps = 0;
        if (number < 1)
        {
            throw new ArgumentOutOfRangeException();
        }
        while (number > 1)
        {
            if (number % 2 == 0)
            {
                number /= 2;
            }
            else
            {
                number = 3 * number + 1;
            }
            steps++;
        }
        return steps;
    }
}
