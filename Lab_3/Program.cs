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
        Console.WriteLine(OldestMember + "\n");

        List<Person> olderThan30 = family.More_than_30_years();
        olderThan30.Sort((person1, person2) => person1.Name.CompareTo(person2.Name));
        for(int i = 0;i < olderThan30.Count;i++)
        {
            Console.WriteLine(olderThan30[i]);
        }
       
    }
}
public class Person
{
    public string Name { set; get; }
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
    public List<Person> More_than_30_years()
    {
        List<Person> people = new List<Person>();
        for (int i = 0; i < family.Count; i++) {
            Person person = family[i];
            if (person.Age > 30) {
                people.Add(person);
            }
        }
        return people;
    }
}