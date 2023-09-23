internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<Employee> employees = new List<Employee>();
        for (int i = 0; i < N; i++) {
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            decimal salary = decimal.Parse(input[1]);
            string position = input[2];
            string department = input[3];
            string email = input[4];
            if (email.Length < 1) {
                email = "n/a";
            }
            int age;
            if (input.Length > 5 && input[5] != " ")
            {
                age = int.Parse(input[5]);
            }
            else {
                age = -1;
            }
            Employee employee = new Employee(name, salary,position,department,email,age);
            employees.Add(employee);
        }
        employees.Sort((person1, person2) => person2.salary.CompareTo(person1.salary));
        print(Salary_departments(employees), employees);
    }
    public static string Salary_departments(List<Employee> employees) {
        string department = "";
        decimal max_salary = 0;
        for (int i = 0; i < employees.Count; i++) {
            decimal salary = employees[i].salary;
            int number_of_employees = 1;
            for (int j = i + 1; j < employees.Count; j++) {
                if (employees[i].department == employees[j].department)
                {
                    salary += employees[j].salary;
                    number_of_employees++;
                }
                else {
                    break;
                }
            }
            decimal average_salary = salary / number_of_employees;
            if (average_salary > max_salary)
            {
                max_salary = average_salary;
                department = employees[i].department;
            }
        }
        return department;
    }
    public static void print(string department, List<Employee> employees) {
        Console.WriteLine("Highest Average Salary: " + department);
        for (int i = 0; i < employees.Count; i++){
            if (employees[i].department == department) {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
class Employee {
    private string name { get; set; }
    public decimal salary {  get; set; }
    private string position { get; set; }
    public string department { get; set; }
    private string email {  get; set; }
    private int age {  get; set; }

    public Employee(string name, decimal salary, string position, string department, string email, int age)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = email;
        this.age = age;
    }
    public override string ToString()
    {
        return $"{name} {salary} {email} {age}";
    }
}