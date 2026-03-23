internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Random numbRand = new();
            Console.WriteLine("Bot: I'm thinking of a number between 1 and 50");
            Console.WriteLine("Choose one of the three difficulties below: ");
            Console.WriteLine("1. Easy (10 chances)");
            Console.WriteLine("2. Medium (5 chances)");
            Console.WriteLine("3. Hard (3 chances)");
            Console.WriteLine("4. Leave");
            Console.Write("Your choice: ");
            string? Diffchoice = Console.ReadLine();
            if (Diffchoice == "1")
            {
                for (int chance = 0; chance < 10; chance++)
                {
                    int rand = numbRand.Next(1, 51);
                    Console.Write("Enter your guess: ");
                    string? userGuess = Console.ReadLine();
                    Console.WriteLine($"Number the console was chosen: {rand}");
                    if (rand.ToString() == userGuess)
                    {
                        Console.WriteLine($"The computer was chosen {rand}, you won!"); break;
                    }
                }
            }
            else if (Diffchoice == "2")
            {
                for (int chance = 0; chance < 5; chance++)
                {
                    int randH = numbRand.Next(1, 51);
                    Console.Write("Enter your guess: ");
                    string? userGuessH = Console.ReadLine();
                    Console.WriteLine($"Number the computer was chosen: {randH}");
                    if (randH.ToString() == userGuessH)
                    {
                        Console.WriteLine($"The computer was chosen {randH}, you won."); break;
                    }
                }
            }
            else if (Diffchoice == "3")
            {
                for (int chance = 0; chance < 3; chance++)
                {
                    int randHH = numbRand.Next(1, 51);
                    Console.Write("Enter your guess: ");
                    string? userGuessHH = Console.ReadLine();
                    Console.WriteLine($"Number the computer was chosen: {randHH}");
                    if (randHH.ToString() == userGuessHH)
                    {
                        Console.WriteLine($"The computer was chosen {randHH}, you won!"); break;
                    }
                }
            }
            else if (Diffchoice == "4")
            {
                Console.WriteLine("I hope you enjoyed it, goodbye! "); break;
            }
        }
    }
}
