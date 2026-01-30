using System;

namespace assessment
{
    public class EmployeeCRUD :EmployeeOperations
    {
        private Employee[] employees = new Employee[10];
        private int count = 0;

        public override void  CreateEmployee(Employee emp)
        {
            if (count < employees.Length)
            {
                employees[count] = emp;
                count++;
                Console.WriteLine("Employee created");
            }
            else
            {
                Console.WriteLine("Employee storage full");
            }
        }
        public override void ReadEmployee()
        {
            for (int i = 0; i < count; i++)
            {

                    Console.WriteLine(employees[i].Name);
                    return;
                
            }
            Console.WriteLine("Employee not found");
        }


        public override void ReadEmployee(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == id)
                {
                    employees[i].Introduce();
                    employees[i].ShowAge();
                    Console.WriteLine("Salary: " + employees[i].Salary);
                    return;
                }
            }
            Console.WriteLine("Employee not found");
        }

       
        public override void UpdateEmployee(int id, double newSalary)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == id)
                {
                    employees[i].UpdateSalary(newSalary);
                    Console.WriteLine("Employee Salary Updated");
                    return;
                }
            }
            Console.WriteLine("Employee not found");
        }

     
        public override void DeleteEmployee(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == id)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        employees[j] = employees[j + 1];
                    }

                    employees[count - 1] = null;
                    count--;
                    Console.WriteLine("Employee deleted");
                    return;
                }
            }
            Console.WriteLine("Employee not found");
        }
    }
}
