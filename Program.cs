// See https://aka.ms/new-console-template for more information
string secreteWords = "Toshmoney";
string secret = "";
int guessCount = 0;
bool outOfGuess = false;
int guessLimit = 3;

while(secret != secreteWords && !outOfGuess)
{
    if(guessCount < guessLimit)
    {
        Console.WriteLine("Guess my secrete words: ");
        secret = Console.ReadLine();
        guessCount++;
    }
    else
    {
        outOfGuess = true;
    }
}
if (outOfGuess)
{
    Console.WriteLine("You Lose With " + guessCount + " attempts!");
}
else
{
    Console.WriteLine("You won! after " + guessCount + " attempt");
}
