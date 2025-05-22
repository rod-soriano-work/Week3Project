using System;

class Program
{
  static void Main(string[] args)
  {
    var reference = new Reference("Proverbs", 3, 5, 6);
    var text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.";
    var scripture = new Scripture(reference, text);

    while (true)
    {
      Console.Clear();
      scripture.Display();

      if (scripture.AllWordsHidden())
      {
        Console.WriteLine("All words are hidden. Press Enter to exit.");
        Console.ReadLine();
        break;
      }

      Console.Write("Press Enter to hide more words or type 'quit' to exit: ");
      string input = Console.ReadLine().Trim().ToLower();
      if (input == "quit")
        break;

      scripture.HideRandomWords(3);
    }
  }
}
