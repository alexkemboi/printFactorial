using System;
class Program
{
    static int printFactorial(int term)
    {
        int factorial = 1;
        for (int i = 1; i <= term; i++)
        {
            factorial = factorial * i;
        }
        return factorial;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to find factorial");
        int term = 0;
        term=Convert.ToInt32(Console.ReadLine());
        int solution=printFactorial(term);
        Console.WriteLine($"The factorial of {term} is:{solution}");

    }
}