using ApplySOLIDInHugeClass.Models;
using ApplySOLIDInHugeClass.Services.Notification;
using ApplySOLIDInHugeClass.Services.Report;

namespace ApplySOLIDInHugeClass;

public class EmployeeManager
{
    private readonly List<Employee> _employees = new();
    private readonly INotificationService _notificationService;
    private readonly IReportStrategy _reportStrategy;

    public EmployeeManager(INotificationService notificationService, IReportStrategy reportStrategy)
    {
        _notificationService = notificationService;
        _reportStrategy = reportStrategy;
    }

    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
        _notificationService.Notify(employee, "Welcome to the company!");
    }

    public void GenerateReports()
    {
        foreach (var employee in _employees)
        {
            _reportStrategy.GenerateReport(employee);
        }
    }

    public void ShowAllEmployees()
    {
        foreach (var employee in _employees)
        {
            Console.WriteLine(employee);
        }
    }
}