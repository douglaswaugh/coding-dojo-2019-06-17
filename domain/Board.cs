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
      Row1 = new int[8] { 0,0,0,0,0,0,0,0 };
      Row2 = new int[8] { 0,0,0,0,0,0,0,0 };
      Row3 = new int[8] { 0,0,0,0,0,0,0,0 };
      Row4 = new int[8] { 0,0,0,1,2,0,0,0 };
      Row5 = new int[8] { 0,0,0,2,1,0,0,0 };
      Row6 = new int[8] { 0,0,0,0,0,0,0,0 };
      Row7 = new int[8] { 0,0,0,0,0,0,0,0 };
      Row8 = new int[8] { 0,0,0,0,0,0,0,0 };
    }
  }
}
