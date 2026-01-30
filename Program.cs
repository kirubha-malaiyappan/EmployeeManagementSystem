using System;

namespace assessment
{
    class Program
    {
        static void Main()
        {
            EmployeeCRUD crud = new EmployeeCRUD();
            int choice;

            do
            {
                Console.WriteLine("\nEmployee Management");
                Console.WriteLine("1. Create Employee");
                Console.WriteLine("2. Read Employee");
                Console.WriteLine("3. Update Salary");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Salary: ");
                        double salary = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Select Role:");
                        Console.WriteLine("1. Manager");
                        Console.WriteLine("2. Team Lead");
                        Console.Write("Enter role choice: ");
                        int roleChoice = Convert.ToInt32(Console.ReadLine());

                        Person emp;

                        if (roleChoice == 1)
                        {
                            emp = new Manager(id, name, age, salary);
                        }
                        else if (roleChoice == 2)
                        {
                            emp = new TeamLead(id, name, age, salary);
                        }
                        else
                        {
                            Console.WriteLine("Invalid role selected");
                            break;
                        }

                        crud.CreateEmployee((Employee)emp);
                        break;

                    case 2:
                        Console.Write("Enter ID: ");
                        int readId = Convert.ToInt32(Console.ReadLine());
                        crud.ReadEmployee(readId);
                        break;

                    case 3:
                        Console.Write("Enter ID: ");
                        int updateId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter new salary: ");
                        double newSalary = Convert.ToDouble(Console.ReadLine());

                        crud.UpdateEmployee(updateId, newSalary);
                        break;

                    case 4:
                        Console.Write("Enter ID: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());

                        crud.DeleteEmployee(deleteId);
                        break;

                    case 5:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != 5);

            Console.WriteLine("Program ended successfully.");
        }
    }
}

