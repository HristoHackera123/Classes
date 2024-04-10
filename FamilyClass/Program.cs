namespace FamilyClass
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                Person person = new Person();
                person.name = Console.ReadLine();
                person.age = int.Parse(Console.ReadLine());
                family.people.Add(person);
            }
            family.Print();
        }
    }
}
