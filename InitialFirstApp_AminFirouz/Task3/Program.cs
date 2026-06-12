//amin firouzi bandpey

Random random = new Random();
int trueNumber = random.Next(1, 11);
int counter = 5;
while (counter >= 1)
{
    Console.WriteLine("enter you guess(1, 10): ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out int userGuessNumber) && (userGuessNumber >= 0 && userGuessNumber <= 10))
    {
        if (userGuessNumber == trueNumber)
        {
            Console.WriteLine("horay, you guessed the number, its {0}", trueNumber);
            break;
        }
        else
        {
            if (counter - 1 == 0)
            {
                Console.WriteLine("GAME OVER!!!, your out of guess!");
            }
            else
            {
                Console.WriteLine("oops, wrong number! you have {0} remaining guesses", counter - 1);
            }
        }
    }
    else
    {
        Console.WriteLine("invalid input! not a number or out of bound");
    }
    counter--;
}