public class Employee
{
    public int EmployeeId;
    public string? EmployeeName;
    public long EmployeeContact;
    public float EmployeeSalary;
    public string? EmployeeJob;

    public static void Main()
    {
        Employee employee1 = new Employee();
        employee1.EmployeeId = 101;
        employee1.EmployeeName = "Sanam";
        employee1.EmployeeContact = 9843808000;
        employee1.EmployeeSalary = 30000;
        employee1.EmployeeJob = "Developer";
    }
    public void Out()
    {
        Console.WriteLine(EmployeeName);
        Console.WriteLine(EmployeeId);
        Console.WriteLine(EmployeeContact);
        Console.WriteLine(EmployeeJob);
        Console.WriteLine(EmployeeSalary);
        Console.ReadLine();
    }



}

