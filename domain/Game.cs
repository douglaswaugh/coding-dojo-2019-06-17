using System;

namespace Domain
{
  public class Game
  {
      private Board _board;
      public int Turn { get; set; }

      public Game()
      {
        Turn = 1;
        _board = new Board();
      }

    public int OpponentsFirstPiece(int[] row)
    {
      for(int i = 1; i <= row.Length; i++)
      {
        if (row[i-1] != Turn)
          return i;
      }

      throw new Exception();
    }
  }
}