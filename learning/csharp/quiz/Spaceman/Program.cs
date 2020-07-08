using System;

namespace Spaceman
{
  class Program
  {
    static void Main(string[] args)
    {
      Game game = new Game();
      game.Greet();
      do
      {
        Console.Clear();
        Console.SetCursorPosition(0, 0);
        game.Display();
        game.Ask();
        if (game.DidWin()==true)
        {
          Console.WriteLine("You saved friend!");
          break;
        }
        if (game.DidLose() == true)
        {
          Console.WriteLine("You lost friend!");
          break;
        }

      }while(true);         
    }
  }
}