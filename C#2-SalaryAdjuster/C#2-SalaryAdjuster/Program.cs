using System.ComponentModel;

public class Employee
{
    public string Name { get; set; }
    public string EmployeeType { get; set; }
    public double Salary { get; set; }

    public Employee(string name, string employeeType, double salary)
    { 
        Name = name;
        EmployeeType = employeeType;
        Salary = salary;
    }

    public void SalaryAdjuster(string employeeType, double salary)
    {
        double newSalary = 0;
        
        if (employeeType == "permanent")
        {
            double raise = salary * 0.10;
            newSalary = salary + raise + 1000;
            Console.WriteLine("Adjusted Salary: " + newSalary);
        }

        else if (employeeType == "contract")
        {
            double raise = salary * 0.05;
            newSalary = salary + raise;
            Console.WriteLine("Adjusted Salary: " + newSalary);
        }

        else if (employeeType == "intern")
        {
            newSalary = salary + 200;
            Console.WriteLine("Adjusted Salary: " + newSalary);
        }

        else
        {
            Console.WriteLine("Please choose between Permanent, Contract, and Intern.");
        }
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        string name;
        string employeeType;
        double salary;
        
        Console.Write("Employee Name: ");
        name = Console.ReadLine();

        Console.Write("Employee Type (Permanent/Contract/Intern): ");
        employeeType = Console.ReadLine().ToLower();

        try
        {
            Console.Write("Salary: ");
            salary = double.Parse(Console.ReadLine());

            Employee employee = new Employee(name, employeeType, salary);
            employee.SalaryAdjuster(employeeType, salary);
        }

        catch (FormatException e)
        {
            Console.WriteLine("Please enter numbers for salary.");
        }
    }
}



