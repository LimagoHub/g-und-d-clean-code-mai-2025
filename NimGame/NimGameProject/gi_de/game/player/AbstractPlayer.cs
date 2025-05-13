namespace gi_de.game.player;

public abstract class AbstractPlayer<BOARD,TURN> : IPlayer<BOARD, TURN>
{
    public AbstractPlayer()
    {
        Name = GetType().Name;
    }

    public AbstractPlayer(string name)
    {
        Name = name;
    }
    public string Name { get; }
    public abstract TURN DoTurn(BOARD board);
}