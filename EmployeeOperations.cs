namespace assessment
{
    public abstract class EmployeeOperations
    {
        public abstract void CreateEmployee(Employee emp);
        public abstract void ReadEmployee();
        public abstract void ReadEmployee(int id);
        public abstract void UpdateEmployee(int id, double newSalary);
        public abstract void DeleteEmployee(int id);
    }
}
