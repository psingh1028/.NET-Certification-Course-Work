using System.Security.Cryptography.X509Certificates;

public class Employee
{
    //fields
    public int empId;
    public string empName = "";
    public double salaryPerHour;
    public int noOfWorkingHours;
    public int netSalary;
    static public string orgazinationName = "Harsha Inc.";
    public const string typeOfEmployee = "Contract Baeed";
    public readonly string departmentName = "Finance Department";
}