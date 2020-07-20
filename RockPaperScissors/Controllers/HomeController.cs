using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Models;

namespace RockPaperScissors.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/rockpaperscissors")]
    public ActionResult RockPaperScissors(string player1, string player2)
    {
      Game ourGame = new Game(player1, player2);
      ourGame.DetectWinner();
      return View(ourGame);
    }
  }
}