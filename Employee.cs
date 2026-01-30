using System;
using assessment;


public class Employee : Person, ICompany
{

    // Properties
    public int Id { get; }
    

    public double Salary { get; private set; }
    

    public Employee(int id, string name, int age, double salary)
        : base(name, age)
    {
        Id = id;
        Salary = salary;
    }

    public override void Introduce()
    {
        Console.WriteLine("Hi, I am " + Name + " (Employee)");
    }

    public override void ShowAge()
    {
        Console.WriteLine("Age: " + age);
    }


    public void CompanyName()
    {
        Console.WriteLine("Employee is working at CC");
    }
 

    public void UpdateSalary(double newSalary)
    {
        Salary = newSalary;
    }
}
