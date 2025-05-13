namespace NimGame.gi_de.game.nimgame;

public class ComputerPlayer: AbstractNimgamePlayer
{
    private readonly int[] zuege ={3,1,1,2};
    public ComputerPlayer()
    {
    }

    public ComputerPlayer(string name) : base(name)
    {
    }

    public override int DoTurn(int stones)
    {
        var turn = zuege[stones % 4];
        Console.WriteLine($"Computer nimmt {turn} Steine.");
        return turn;
    }
}