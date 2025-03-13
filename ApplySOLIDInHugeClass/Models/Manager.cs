using ApplySOLIDInHugeClass.Services.Bonus;

namespace ApplySOLIDInHugeClass.Models;

public class Manager : Employee
{
    public Manager(string name, double salary, string department) : base(name, salary, department, new ManagerBonus())
    {
    }
}