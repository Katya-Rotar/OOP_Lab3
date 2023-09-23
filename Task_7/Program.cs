internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            string madel = input[0];
            double fuel_amount = double.Parse(input[1]);
            double fuel_consumption_1Km = double.Parse(input[2]);
            Car car = new Car(madel, fuel_amount, fuel_consumption_1Km);
            cars.Add(car);
        }
        string end;
        Console.WriteLine("Drive");
        while ((end = Console.ReadLine()) != "End")
        {
            string[] input = end.Split();
            string madel = input[0];
            double distance_traveled = double.Parse(input[1]);
            CarMove(madel, distance_traveled, cars);
        }
        print(cars);
    }
    public static void CarMove(string madel, double distance_traveled, List<Car> cars)
    {
        for (int i = 0; i < cars.Count; i++)
        {
            if (cars[i].model == madel)
            {
                double used_fuel = cars[i].fuel_consumption_1Km * distance_traveled;
                if (used_fuel <= cars[i].fuel_amount)
                {
                    cars[i].fuel_amount = cars[i].fuel_amount - used_fuel;
                    cars[i].distance_traveled += distance_traveled;
                }
                else {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
        }
    }
    public static void print(List<Car> cars) {
        foreach (Car car in cars) {
            Console.WriteLine(car);
        }
    }
}
class Car {
    public string model { get; set; }
    public double fuel_amount {  get; set; }
    public double fuel_consumption_1Km { get; set; }
    public double distance_traveled { get; set; }

    public Car(string model, double fuel_amount, double fuel_consumption_1Km) {
        this.model = model;
        this.fuel_amount = fuel_amount;
        this.fuel_consumption_1Km = fuel_consumption_1Km;
        distance_traveled = 0;
    }
    public override string ToString()
    {
        return $"{model} {fuel_amount} {distance_traveled}";
    }
}