namespace assessment
{
    public class TeamLead : Employee
    {
        public TeamLead(int id, string name, int age, double salary)
            : base(id, name, age, salary)
        {
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I am " + Name + " (Team Lead)");
        }
    }
}
