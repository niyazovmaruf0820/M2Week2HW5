using Domain.Models;
namespace Infrastructure.Services;

public class EmployeeService
{
    List<Employee> employees = new List<Employee>();
    public List<Employee> GetEmployees()
    {
        return employees;
    }
    public void AddEmployees(Employee employee)
    {
        employees.Add(employee);
    }
    public int CountEmployee()
    {
        return employees.Count;
    }
}
