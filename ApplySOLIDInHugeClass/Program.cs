// See https://aka.ms/new-console-template for more information

using ApplySOLIDInHugeClass;
using ApplySOLIDInHugeClass.Models;
using ApplySOLIDInHugeClass.Services.Notification;
using ApplySOLIDInHugeClass.Services.Report;

INotificationService emailService = new EmailNotification();
IReportStrategy pdfReport = new PdfReport();

EmployeeManager employeeManager = new EmployeeManager(emailService, pdfReport);

Employee manager = new Manager("Jad", 5000, "HR");
Employee developer = new Developer("Otmane", 3000, "IT ICD .Net");
Employee intern = new Intern("Khalil", 1000, "IT Microsoft");

employeeManager.AddEmployee(manager);
employeeManager.AddEmployee(developer);
employeeManager.AddEmployee(intern);

employeeManager.ShowAllEmployees();
employeeManager.GenerateReports();