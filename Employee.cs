using assessment;
using System.Xml.Linq;

public class Employee : Person, IWorker
{
    // Fields
    private int id;
    private double salary;

    // Properties
    public int Id
    {
        get { return id; }
    }

    public double Salary
    {
        get { return salary; }
    }

    public Employee(int id, string name, int age, double salary)
        : base(name, age)
    {
        this.id = id;
        this.salary = salary;
    }

    public override void Introduce()
    {
        Console.WriteLine("Hi, I am " + Name + " (Employee)");
    }

    public void Work()
    {
        Console.WriteLine("Employee is working at backend technology");
    }

    public void UpdateSalary(double newSalary)
    {
        salary = newSalary;
    }
}
