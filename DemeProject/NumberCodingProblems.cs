
public static class NumberCodingProblems
{

    public static void CalculateFatorialNumber()
    {
        int number = 5;
        if (number == 0)//Edge Case
        {
            Console.WriteLine(1);
        }
        long result = 1; //Set Inital Value
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        Console.WriteLine(result);
    }

    public static void IsPrime()
    {
        int number = 17;
        if (number <= 1)
            Console.WriteLine(false);

        for (int i = 2; i < number / 2; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(false);
            }
        }
        Console.WriteLine(true);
    }
    public static void SubOfDigitsMethod()
    {
        int number = 1234;
        int sum = 0;
        while (number != 0)
        {
            int remainder = number % 10;
            sum += remainder;
            number = number / 10;
        }
        Console.WriteLine(sum);
    }

    public static void GenerateFibonacci()
    {
        int number = 7;
        int a = 0, b = 1;
        Console.WriteLine(a + "," + b);
        for (int i = 2; i < number; i++)
        {
            int next = a + b;// Add immediate previous two number
            Console.WriteLine("," + next);
            a = b;// Rest a to b
            b = next;// rest b to next
        }
    }
}