using ApplySOLIDInHugeClass.Models;

namespace ApplySOLIDInHugeClass.Services.Report;

public interface IReportStrategy
{
    void GenerateReport(Employee employee);
}