using System;

namespace assessment
{
    class Program
    {
        static void Main()
        {
            EmployeeCRUD crud = new EmployeeCRUD();
            Employee emp1 = new Manager(1, "Anu", 41, 50000);
            crud.CreateEmployee(emp1);
            crud.ReadEmployee();
            crud.UpdateEmployee(emp1.Salary+ 150000);
            Console.WriteLine($"Update Salary {emp1.Salary}");
            crud.DeleteEmployee();
            
            Employee emp2 = new TeamLead(2, "Ravi", 30, 40000);
            crud.CreateEmployee(emp2);
            crud.ReadEmployee();
            crud.UpdateEmployee(45000);

        }
    }
}
