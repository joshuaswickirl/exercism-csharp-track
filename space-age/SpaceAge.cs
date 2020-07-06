// SpaceAge converts an age in seconds to the number of 
// years on a given planet
public class SpaceAge
{
    private readonly double earthAge;
    private const double earthYearInSeconds = 31_557_600.0;
    
    public SpaceAge(int seconds) =>
        earthAge = seconds / earthYearInSeconds;

    public double OnEarth()   => earthAge / 1.00;
    public double OnMercury() => earthAge / 0.2408467;
    public double OnVenus()   => earthAge / 0.61519726;
    public double OnMars()    => earthAge / 1.8808158;
    public double OnJupiter() => earthAge / 11.862615;
    public double OnSaturn()  => earthAge / 29.447498;
    public double OnUranus()  => earthAge / 84.016846;
    public double OnNeptune() => earthAge / 164.79132;
}
