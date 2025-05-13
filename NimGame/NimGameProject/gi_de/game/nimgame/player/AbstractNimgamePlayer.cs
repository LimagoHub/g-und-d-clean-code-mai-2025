using gi_de.game.player;

namespace NimGame.gi_de.game.nimgame;

public abstract class AbstractNimgamePlayer: AbstractPlayer<int,int>
{
    protected AbstractNimgamePlayer()
    {
    }

    protected AbstractNimgamePlayer(string name) : base(name)
    {
    }

    public abstract override int DoTurn(int stones);
}