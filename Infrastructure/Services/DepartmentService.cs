using Domain.Models;

namespace Infrastructure.Services;

public class DepartmentService
{
    List<Department> departments = new List<Department>();
    public List<Department> GetDepartments()
    {
        return departments;
    }
    public void AddDepartment(Department department)
    {
        departments.Add(department);
    }
    public int CountDepartments()
    {
        return departments.Count;
    }
}
