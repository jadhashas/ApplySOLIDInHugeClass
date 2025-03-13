namespace ApplySOLIDInHugeClass.Services.Bonus;

public class ManagerBonus : IBonusStrategy
{
    public double CalculateBonus(double salary)
    {
        return salary * 0.2;
    }
}