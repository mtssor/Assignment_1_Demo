namespace Assignment_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("My name is Mats");

        CountTo(4);
    }
    
    
    /// <summary>
    /// Counts from zero to the provided number
    /// </summary>
    /// <param name="number"></param>
    static void CountTo(int number)
    {
        Console.WriteLine("Counting to" + number + "...");
        for (int i = 1; i <= number; i++) ;
        {
            Console.WriteLine(i);
        }

        Console.WriteLine(num);
    }
}