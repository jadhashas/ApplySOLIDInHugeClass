namespace ApplySOLIDInHugeClass.Services.Bonus;

public class DeveloperBonus : IBonusStrategy
{
    public double CalculateBonus(double salary)
    {
        return salary * 0.1;
    }
}