// amin firouzi bandpey

Console.WriteLine("please enter your name: ");
string name = Console.ReadLine();
Console.WriteLine("Please enter your age: ");
string age = Console.ReadLine();

if (int.TryParse(age, out int ageInt))
{
    Console.WriteLine($"Name: {name}, Age: {ageInt}");
}
else
{
    Console.WriteLine("age is not a valid number!");
}
