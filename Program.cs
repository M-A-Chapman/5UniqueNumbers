namespace _5UniqueNumbers;
class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>();

        while (numbers.Count < 5)
        {
            Console.WriteLine("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            if (numbers.Contains(number))
            {
                System.Console.WriteLine("This number has already been entered, please enter a new number");
            }
            else
            {
                numbers.Add(number);
            }
        };
        numbers.Sort();
        System.Console.WriteLine("The Sorted list of numbers is as follows:");
        numbers.ForEach(Console.WriteLine);
    }
}
