using Nancy;
using System.Collections.Generic;
using RockPaperScissors.Objects;

namespace RockPaperScissors
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        Game RockPaperScissors = new Game();
        string result = RockPaperScissors.Compare(Request.Form["player1"], Request.Form["player2"]);
        return View["index.cshtml", result];
      };
    }
  }
}
