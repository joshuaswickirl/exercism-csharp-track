using System;

public class SpaceAge
{
    private double spaceAge;
    public SpaceAge(int seconds)
    {
        spaceAge = (seconds / 60.0 / 60.0 / 24.0 / 365.25);
    }

    public double OnEarth()
    {
        return spaceAge / 1.00;
    }

    public double OnMercury()
    {
        return spaceAge / 0.2408467;
    }

    public double OnVenus()
    {
        return spaceAge / 0.61519726;
    }

    public double OnMars()
    {
        return spaceAge / 1.8808158;
    }

    public double OnJupiter()
    {
        return spaceAge / 11.862615;
    }

    public double OnSaturn()
    {
        return spaceAge / 29.447498;
    }

    public double OnUranus()
    {
        return spaceAge / 84.016846;
    }

    public double OnNeptune()
    {
        return spaceAge / 164.79132;
    }
}
