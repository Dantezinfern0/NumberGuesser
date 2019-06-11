using System;
namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      int newGuess = 50;
      int upper = 100;
      int lower = 1;
      int tries = 1;
      var guess = "";
      Console.WriteLine("Guess a Number Between 1 and 100.");
      Console.WriteLine($"Is your number {newGuess}?  If not tell me if it's higher or lower");
      Console.WriteLine("Type in: yes, higher, or lower to continue");
      while (guess != "yes")
      {
        guess = Console.ReadLine();
        if (guess.ToLower() == "higher")
        {
          lower = newGuess + 1;
          newGuess = (lower + upper) / 2;
          Console.WriteLine($"Your Number {newGuess}");
          Console.WriteLine("Type in: yes, higher, or lower to continue");
          tries++;
        }
        if (guess.ToLower() == "lower")
        {
          upper = newGuess - 1;
          newGuess = (lower + upper) / 2;
          Console.WriteLine($"Your Number {newGuess}");
          Console.WriteLine("Type in: yes, higher, or lower to continue");
          tries++;
        }
        Console.WriteLine("Make Sure to Enter a Valid Response");

      }
      Console.WriteLine("I knew it!");
      Console.WriteLine($"It only took me {tries}");
    }
  }
}
