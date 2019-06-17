using System;

namespace Domain
{
  public class Board
  {
    public int[] Row1 { get; set; }
    public int[] Row2 { get; set; }
    public int[] Row3 { get; set; }
    public int[] Row4 { get; set; }
    public int[] Row5 { get; set; }
    public int[] Row6 { get; set; }
    public int[] Row7 { get; set; }
    public int[] Row8 { get; set; }

    public Board()
    {
      var emptyRow = new int[8] { 0,0,0,0,0,0,0,0 };

      Row1 = emptyRow;
      Row2 = emptyRow;
      Row3 = emptyRow;
      Row4 = new int[8] { 0,0,0,1,2,0,0,0 };
      Row5 = new int[8] { 0,0,0,2,1,0,0,0 };
      Row6 = emptyRow;
      Row7 = emptyRow;
      Row8 = emptyRow;
    }
  }
}
