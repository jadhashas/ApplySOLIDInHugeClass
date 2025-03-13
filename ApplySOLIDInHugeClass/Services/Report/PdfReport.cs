using ApplySOLIDInHugeClass.Models;

namespace ApplySOLIDInHugeClass.Services.Report;

public class PdfReport:IReportStrategy
{
    public void GenerateReport(Employee employee)
    {
        Console.WriteLine($"Generating PDF Report for {employee.Name}...");
    }
}