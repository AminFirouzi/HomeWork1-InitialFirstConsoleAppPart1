// See https://aka.ms/new-console-template for more information

bool IsOdd(int number) => number % 2 == 1;

int SumOfAllOdds(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i ++)
        if (IsOdd(i))
            sum += i;
    
    return sum;
}

Console.WriteLine("enter a number(greater than 1):");

string userInput = Console.ReadLine();
if (int.TryParse(userInput, out int number))
{
    if(number <  1)
        Console.WriteLine("i said greater than 1!!!!");
    else
    {
        for(int i = 1; i <= number; i++)
            if(IsOdd(i))
                Console.WriteLine(i);
        Console.WriteLine("sum of all odd number: {0}", SumOfAllOdds(number));

        
    }
}
else
{
    Console.WriteLine("invalid input");
}