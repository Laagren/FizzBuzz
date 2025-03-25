using System;
class fizzbuzz
{
    static void Main(string[] args)
    {
        string[] inputStrings = Console.ReadLine().Split(" ");
        Console.Write("\n");
        int N, X, Y;
        int.TryParse(inputStrings[0], out X);
        int.TryParse(inputStrings[1], out Y);
        int.TryParse(inputStrings[2], out N);

        for (int i = 1; i <= N; i++)
        {
            if (i % X == 0)
            {
                Console.Write("Fizz");
                if (i % Y == 0)
                {
                    Console.Write("Buzz");
                }
                Console.Write("\n");
            }
            else if (i % Y == 0)
            {
                Console.WriteLine("Buzz");
            }
            else Console.WriteLine(i);
        }
    }
}