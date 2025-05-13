namespace NimGame.gi_de.game.nimgame;

public class HumanPlayer: AbstractNimgamePlayer
{
    public HumanPlayer()
    {
    }

    public HumanPlayer(string name) : base(name)
    {
    }

    public override int DoTurn(int stones)
    {
        Console.WriteLine($"Es gibt {stones} Steine. Bitte nehmen Sie 1, 2 oder 3!");
        var input = Console.ReadLine();
        return int.Parse(input);
    }
}