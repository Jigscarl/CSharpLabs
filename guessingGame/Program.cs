var rng = new Random();
int numberToGuess = rng.Next(1, 101);
int attempts = 0;

Console.WriteLine("Im thinking of a number between 1 and 100. Can you guess what it is?");

while(true)
{
Console.Write("Enter your guess:");
String? Input = Console.ReadLine();

if(!int.TryParse(Input, out int UserGuess))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    continue;
}


attempts++;
if(UserGuess < numberToGuess)
{
    Console.WriteLine("Too Low! Try again.");
}
else if(UserGuess > numberToGuess)
{
    Console.WriteLine("Too High! Try again.");
}
else
{
    Console.WriteLine($"Congratulations! You guessed the number {numberToGuess} in {attempts} attempts.");
    break;
}
}