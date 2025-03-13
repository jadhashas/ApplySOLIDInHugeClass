using ApplySOLIDInHugeClass.Models;

namespace ApplySOLIDInHugeClass.Services.Notification;

public interface INotificationService
{
    void Notify(Employee employee, string message);
}