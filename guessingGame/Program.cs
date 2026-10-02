var rng = new Random();
int numberToGuess = rng.Next(1, 101);
int attempts = 0;
int maxAttempts = 7;
bool hasWon = false;

Console.WriteLine("Im thinking of a number between 1 and 100. Can you guess what it is?");
Console.WriteLine($"You have {maxAttempts} attempts to guess the number.");

while(attempts < maxAttempts)
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
    Console.WriteLine($"Too Low! Try again. You have {maxAttempts - attempts} attempts left.");
}
else if(UserGuess > numberToGuess)
{
    Console.WriteLine($"Too High! Try again. You have {maxAttempts - attempts} attempts left.");
}
else
{
    Console.WriteLine($"Congratulations! You guessed the number {numberToGuess} in {attempts} attempts.");
    hasWon = true;
    break;
}
}
if(!hasWon)
{
    Console.WriteLine($"Sorry, you've run out of attempts. The number was {numberToGuess}.");
}

