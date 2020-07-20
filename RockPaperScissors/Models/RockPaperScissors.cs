namespace RockPaperScissors.Models
{
  public class Game
  {
    public string Player1 { get; set; }
    public string Player2 { get; set; }

    public Game(string player1, string player2)
    {
      Player1 = player1;
      Player2 = player2;
    }
    public string DetectWinner()
    {
      if (Player1 == Player2) 
      {
        return "Draw";
      }
      else if (Player1 == "rock" && Player2 == "scissors" || Player1 == "scissors" && Player2 == "paper" || Player1 == "paper" && Player2 == "rock")
      {
        return "Player 1 Win";
      }
      else
      {
        return "Player 2 Win";
      }
    }
  }
}





