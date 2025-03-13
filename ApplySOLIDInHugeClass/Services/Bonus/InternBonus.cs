namespace ApplySOLIDInHugeClass.Services.Bonus;

public class InternBonus: IBonusStrategy
{
    public double CalculateBonus(double salary)
    {
        return salary * 0.05;
    }
}