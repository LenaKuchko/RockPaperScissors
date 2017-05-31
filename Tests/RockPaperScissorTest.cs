using Xunit;
using System;
using RockPaperScissors.Objects;

namespace RockPaperScissors
{
  public class PaperRockScissorsTests
  {
    // [Fact]
    // public void PapervsRock_Paper_Win()
    // {
    //   Game instance = new Game();
    //   string winner = instance.Compare("Rock", "Paper");
    //   Assert.Equal("Paper is winner", winner);
    // }
    [Fact]
    public void RockvsScissors_Rock_Win()
    {
      Game instance = new Game();
      string winner = instance.Compare("Scissors", "Rock");
      Assert.Equal("Rock is winner", winner);
    }
  }
}
