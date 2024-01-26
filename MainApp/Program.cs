using Domain.Models;
using Infrastructure.Services;

Employee employee = new Employee();
employee.FirstName = "Maruf";
employee.LastName = "Niyazov";
employee.BirthDate =new DateTime(2008,10,30);
employee.Salary = 100000;
employee.Department = new Department();
employee.Department.Name = "IT";
employee.Department.Description = "Programm place";
Employee employee2 = new Employee();
employee2.FirstName = "Jake";
employee2.LastName = "David";
employee2.BirthDate = DateTime.Now;
employee2.Salary = 10000;
employee2.Department = new Department();
employee2.Department.Name = "Design";
employee2.Department.Description = "Design place";
EmployeeService employeeService = new EmployeeService();
employeeService.AddEmployees(employee);
employeeService.AddEmployees(employee2);
System.Console.WriteLine("Employees: " + employeeService.CountEmployee());
System.Console.WriteLine();
foreach (var item in employeeService.GetEmployees())
{
    System.Console.Write("Name: " + item.FirstName + " ");
    System.Console.WriteLine(item.LastName);
    System.Console.WriteLine("Birthday: " + item.BirthDate);
    System.Console.WriteLine("Salary: " + item.Salary);
    System.Console.WriteLine("Department's name: " + item.Department.Name);
    System.Console.WriteLine("Department's description: " + item.Department.Description);
    System.Console.WriteLine("-------------------------------------");
}

 
