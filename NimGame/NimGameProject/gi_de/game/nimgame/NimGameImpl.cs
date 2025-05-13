using NimGame.gi_de.game.nimgame;

namespace gi_de.game.nimgame;

public class NimGameImpl: AbstractGame<int,int>
{

    
  

    public NimGameImpl()
    {
        Board = 23;
    
    }

  

    
    protected override bool IsTurnValid()
    {
        return Turn >= 1 && Turn <= 3;
    }
    protected override  void UpdateBoard()
    {
        Board -= Turn;
    }

    protected override bool IsGameOver() // Operation
    {
        return Board < 1 || Players.Count == 0;
    }
}