using ApplySOLIDInHugeClass.Models;

namespace ApplySOLIDInHugeClass.Services.Notification;

public class SmsNotification : INotificationService
{
    public void Notify(Employee employee, string message)
    {
        Console.WriteLine($"Sending SMS to {employee.Name}: {message}");
    }
}