// CONSOLE COLOR
Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.ForegroundColor = ConsoleColor.Black;

// ASKING USER'S NAMES
Console.Write("What's your name User 1: ");
string user1 = Console.ReadLine();
Console.Write("What's your name User 2: ");
string user2 = Console.ReadLine();

// ASKING USER 1
int number;
do
{
    Console.Write($"{user1} enter a number between 0 and 100: ");
    number = Convert.ToInt32(Console.ReadLine());
} while (number < 0 || number > 100);
Console.Clear();

// ASKING USER 2
Console.WriteLine($"{user2}, guess the number.");

// GUESS OF USER 2
int guess;
do
{
    Console.Write("What's your next guess: ");
    guess = Convert.ToInt32(Console.ReadLine());
    
    //GUESS TOO LOW
    if (guess < number)
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"{guess} is too low.");
    }
    //GUESS TOO HIGH
    else if (guess > number)
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"{guess} is too high.");
    }

} while (guess != number);
Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"{user2} guessed the number!");
