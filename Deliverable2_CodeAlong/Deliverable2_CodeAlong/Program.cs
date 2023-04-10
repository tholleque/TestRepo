Console.WriteLine("Welcome to the Coin Flip Challenge.");
Console.WriteLine("What is your name?");

string name = Console.ReadLine();

Console.WriteLine($"Well {name}, would you like to do the coin flip challenge? y/n");
string response  = Console.ReadLine();

if (response == "y")
{
    int correctGuess = 0;
    for(int i = 0;i < 5; i++)
    {
        Random r = new Random();
        int roll = r.Next(0,2);
        string result;
        if(roll == 0)
        {
            result = "heads";
        }
        else
        {
            result = "tails";
        }
        Console.WriteLine($"Round number {i}");
        Console.WriteLine("Guess the flip input heads or tails");
        string guess = Console.ReadLine();

        if (guess == result)
        {
            Console.WriteLine("Correct");
            correctGuess++;
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }

    Console.WriteLine($"You got {correctGuess} out of 5.");

}
else
{
    Console.WriteLine($"You are a coward, {name}!");
}