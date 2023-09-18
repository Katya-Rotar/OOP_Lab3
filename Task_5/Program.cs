internal class Program
{
    private static void Main(string[] args)
    {
        string date1 = Console.ReadLine();
        string date2 = Console.ReadLine();
        DateModifier dateModifier = new DateModifier();
        Console.WriteLine(dateModifier.CalculateDate(date1, date2));

    }
}
class DateModifier {
    public int CalculateDate(string date_1, string date_2){
        DateTime dateTime = DateTime.Parse(date_1);
        DateTime dateTime_2 = DateTime.Parse(date_2);
        TimeSpan difference_of_the_days = dateTime - dateTime_2;
        return Math.Abs(difference_of_the_days.Days);
        }
}