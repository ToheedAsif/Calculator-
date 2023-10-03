namespace Calculator;
class Program
{
    static void Main(string[] args)

    {
        
        Console.WriteLine("Welcome to the calculator!");
        Console.WriteLine("Write a number");
        string? str1 = Console.ReadLine();
        float num1 = float.Parse(str1);


        Console.WriteLine ("what is your second number");
        string? str2 = Console.ReadLine();
        float num2 = float.Parse(str1);

        Console.WriteLine (num2 * num1);

    }
}
