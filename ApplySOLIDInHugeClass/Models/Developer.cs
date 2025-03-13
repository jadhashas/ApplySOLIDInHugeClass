using ApplySOLIDInHugeClass.Services.Bonus;

namespace ApplySOLIDInHugeClass.Models;

public class Developer : Employee
{
    public Developer(string name, double salary, string department) : base(name, salary, department , new DeveloperBonus())
    {
    }
}