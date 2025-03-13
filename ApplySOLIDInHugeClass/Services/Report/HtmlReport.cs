using ApplySOLIDInHugeClass.Models;

namespace ApplySOLIDInHugeClass.Services.Report;

public class HtmlReport : IReportStrategy
{
    public void GenerateReport(Employee employee)
    {
        Console.WriteLine($"Generating HTML Report for {employee.Name}...");
    }
}