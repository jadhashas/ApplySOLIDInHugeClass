using ApplySOLIDInHugeClass.Services.Bonus;

namespace ApplySOLIDInHugeClass.Models;

public abstract class Employee
{
    public string Name { get; }
    public double Salary { get; private set; }
    public string Department { get; }
    public IBonusStrategy BonusStrategy { get; set; }

    protected Employee(string name, double salary, string department, IBonusStrategy bonusStrategy)
    {
        Name = name;
        Salary = salary;
        Department = department;
        BonusStrategy = bonusStrategy;
    }

    public double CalculateBonus() => BonusStrategy.CalculateBonus(Salary);

    public override string ToString() => $"{Name} ({Department}) - Salary: {Salary} - Bonus: {CalculateBonus()}";
}