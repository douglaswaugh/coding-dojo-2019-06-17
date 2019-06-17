using System;

namespace Domain
{
  public class Game
  {
      public string Turn { get; set; }

      public Game()
      {
        Turn = "white";
      }
  }
}