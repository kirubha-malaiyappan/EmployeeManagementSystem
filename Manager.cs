namespace assessment
{
    public class Manager : Employee
    {
        public Manager(int id, string name, int age, double salary)
            : base(id, name, age, salary)
        {
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I am " + Name + " (Manager)");
        }
    }
}
