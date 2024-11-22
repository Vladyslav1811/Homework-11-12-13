internal class Program
{
    static int GetFibonacci(int n)
    {
        if (n < 0)
            throw new ArgumentException("Input must be a non-negative integer.");
        if (n == 0) return 0;
        if (n == 1) return 1;

        return GetFibonacci(n - 1) + GetFibonacci(n - 2);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Fibonacci sequence index (non-negative integer):");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0)
        {
            try
            {
                int result = GetFibonacci(index);
                Console.WriteLine($"The Fibonacci number at index {index} is: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
        }
    }
}