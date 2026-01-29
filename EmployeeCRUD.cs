public class EmployeeCRUD
{
    private Employee? employee;
    private bool isCreated = false;

    public void CreateEmployee(Employee emp)
    {
        if (!isCreated)
        {
            employee = emp;
            isCreated = true;
            Console.WriteLine("Employee created");
        }
        else
        {
            Console.WriteLine("Employee already exists");
        }
    }

    public void ReadEmployee()
    {
        if (isCreated && employee != null)
        {
            employee.Introduce();
            employee.ShowAge();
            Console.WriteLine("Salary: " + employee.Salary);
        }
        else
        {
            Console.WriteLine("No employee found");
        }
    }

    public void UpdateEmployee(double newSalary)
    {
        if (isCreated && employee != null)
        {
            employee.UpdateSalary(newSalary);
            Console.WriteLine("Salary updated");
        }
    }

    public void DeleteEmployee()
    {
        employee = null;
        isCreated = false;
        Console.WriteLine("Employee deleted");
    }
}
