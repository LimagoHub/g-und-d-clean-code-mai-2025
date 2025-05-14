namespace NimGame.gi_de.game.nimgame;

public class OmaPlayer: AbstractNimgamePlayer
{
    private Random Rand { get; } = new Random();
    public OmaPlayer()
    {
    }

    public OmaPlayer(string name) : base(name)
    {
    }

    public override int DoTurn(int stones)
    {
        var turn = Rand.Next(6);
        Console.WriteLine($"{Name} nimmt {turn} Steine.");
        return turn;
    }
}