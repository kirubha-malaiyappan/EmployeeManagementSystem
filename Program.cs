using System;

namespace assessment
{
    class Program
    {
        static void Main()
        {
            EmployeeCRUD crud = new EmployeeCRUD();

            Person emp = new Manager(1, "Kiru", 21, 50000);

            crud.CreateEmployee((Employee)emp);

            crud.ReadEmployee();
        }
    }
}
