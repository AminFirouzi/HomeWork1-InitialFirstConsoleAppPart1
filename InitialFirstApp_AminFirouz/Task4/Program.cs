//amin firouzi

string trueWord = "CSharp";
int guessCounter = 1;


while (true)
{
    Console.WriteLine("enter your guess:");
    string userInput = Console.ReadLine();
    if (userInput != trueWord)
    {
        guessCounter++;
        Console.WriteLine("oops, you guessed wrong!");
        continue;
    }
    else
    {
        Console.WriteLine("hooray, after {0} times, you guessed the true word {1}", guessCounter, trueWord);
        break;
    }
}
