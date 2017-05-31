using System;
using System.Collections.Generic;

namespace RockPaperScissors.Objects
{
  public class Game
  {
    // public string Player1;
    // public string Player2;

    public string Compare(string Player1, string Player2)
    {
      if (Player1 == "Rock" && Player2 == "Paper")
      {
        return "Paper is winner";
      }
      else if (Player1 == "Scissors" && Player2 == "Rock")
      {
        return "Rock is winner";
      }

    }
  }
}
