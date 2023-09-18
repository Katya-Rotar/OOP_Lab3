internal class Program
{
    private static void Main(string[] args)
    {
        Person person_1 = new Person("Pesho", 20);
        Person person_2 = new Person("Gosho", 18);
        Person person_3 = new Person("Stamat", 43);

        Console.WriteLine("Enter the value N");
        int N = int.Parse(Console.ReadLine());

        Family family = new Family();

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Enter the name of person");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the age of person");
            int age = int.Parse(Console.ReadLine());
            Person person = new Person(name, age);
            family.AddMember(person);
        }
        Person OldestMember = family.GetOldestMember();
        Console.WriteLine(OldestMember);
    }
}
public class Person
{
    private string Name { set; get; }
    public int Age { set; get; }
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public Person()
    {
        this.Name = "No name";
        this.Age = 1;
    }
    public Person(int age)
    {
        this.Name = "No name";
        this.Age = age;
    }
    public override string ToString()
    {
        return $"{Name} {Age}";
    }
}
public class Family
{
    private List<Person> family = new List<Person>();
    public void AddMember(Person person)
    {
        family.Add(person);
    }
    public Person GetOldestMember()
    {
        int older_index = 0;
        for (int i = 1; i < family.Count; i++)
        {
            if (family[i].Age > family[older_index].Age)
            {
                older_index = i;
            }

        }
        return family[older_index];
    }
}