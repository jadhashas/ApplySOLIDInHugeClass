using ApplySOLIDInHugeClass.Models;

namespace ApplySOLIDInHugeClass.Services.Notification;

public class EmailNotification : INotificationService
{
    public void Notify(Employee employee, string message)
    {
        Console.WriteLine($"Sending Email to {employee.Name}: {message}");
    }
}