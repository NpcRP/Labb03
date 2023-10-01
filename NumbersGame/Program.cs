namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen!");

            string playAgain;
            do
            {
                Console.WriteLine("Snälla välj svårighetsgrad (1-5):");
                int difficulty = int.Parse(Console.ReadLine());

                int maxNumber = difficulty * 10;
                int maxTries = 6 - difficulty;

                Console.WriteLine($"Jag tänker på ett nummer mellan 1 och {maxNumber}. Kan du gissa vilket? Du får {maxTries} försök.");

                Random random = new Random();
                int number = random.Next(1, maxNumber + 1);

                int tries = 0;
                while (tries < maxTries)
                {
                    int guess = int.Parse(Console.ReadLine());
                    tries++;

                    if (guess == number)
                    {
                        Console.WriteLine("Wohoo! Du klarade det!");
                        break;
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("Tyvärr, du gissade för lågt!");
                    }
                    else
                    {
                        Console.WriteLine("Tyvärr, du gissade för högt!");
                    }
                }

                if (tries == maxTries)
                {
                    Console.WriteLine($"Tyvärr, du lyckades inte gissa talet på {maxTries} försök!");
                }

                Console.WriteLine("Vill du spela igen? (Y/N)");
                playAgain = Console.ReadLine().ToUpper();
            }
            while (playAgain == "Y");
        }
    }
}
