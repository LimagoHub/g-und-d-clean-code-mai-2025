namespace gi_de.game.player;

public interface IPlayer<BOARD,TURN>
{
    public string Name { get;  }
    public TURN DoTurn(BOARD board);
}