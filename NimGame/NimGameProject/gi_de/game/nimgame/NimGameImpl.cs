namespace gi_de.game.nimgame;

public class NimGameImpl: IGame
{

    private int _stones;
    private int _turn;

    public NimGameImpl()
    {
        _stones = 23;
    
    }

    public void Play()
    {
        while (!IsGameOver())
        {
            PlayRound();
        }
    }

    private void PlayRound()  // Integration
    {
        HumanTurn();
        ComputerTurn();
    }


    private void HumanTurn()
    {
        if (IsGameOver()) return;
        
        
        while (true)
        {
            Console.WriteLine($"Es gibt {_stones} Steine. Bitte nehmen Sie 1, 2 oder 3!");
            var input = Console.ReadLine();
            _turn = int.Parse(input);
            if (_turn >= 1 && _turn <= 3) break;
            Console.WriteLine("Ungueltiger Zug!");
        }

        TerminateTurn( "Spieler");
    }
    private void ComputerTurn()
    {
        if (IsGameOver()) return;
        int[] zuege ={3,1,1,2};
     
        _turn = zuege[_stones % 4];
        Console.WriteLine($"Computer nimmt {_turn} Steine.");
        
        TerminateTurn("Computer");
    }

    private void TerminateTurn( string player) // Integration
    {
        UpdateBoard();
        PrintGameoverMessageIfGameIsOver(player);
    }

    private void PrintGameoverMessageIfGameIsOver(string player)
    {
        if (IsGameOver())
        {
            Console.WriteLine($"{player} hat verloren");
        }
    }


    // ---------------------- Implementierungssumpf
    private void UpdateBoard()
    {
        _stones -= _turn;
    }

    private bool IsGameOver() // Operation
    {
        return _stones < 1;
    }
}