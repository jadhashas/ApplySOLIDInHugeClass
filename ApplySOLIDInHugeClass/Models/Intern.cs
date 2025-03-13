using ApplySOLIDInHugeClass.Services.Bonus;

namespace ApplySOLIDInHugeClass.Models;

public class Intern : Employee
{
    public Intern(string name, double salary, string department) : base(name, salary, department, new InternBonus())
    {
    }
}