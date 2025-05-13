using gi_de.game.player;

namespace gi_de.game;

public abstract class AbstractGame<BOARD,TURN> : IGame
{
    
    private readonly IList<IPlayer<BOARD,TURN>> _players = new List<IPlayer<BOARD, TURN>>();
    private IPlayer<BOARD,TURN> _currentPlayer;
    
    private TURN _turn;
    private BOARD _board;
    protected IPlayer<BOARD,TURN> CurrentPlayer
    {
        get => _currentPlayer;
        private set => _currentPlayer = value;
    }

    protected IList<IPlayer<BOARD,TURN>> Players => _players;

    protected TURN Turn
    {
        get => _turn;
        set => _turn = value;
    }

    protected BOARD Board
    {
        get => _board;
        set => _board = value;
    }

    public void AddPlayer(IPlayer<BOARD,TURN> player)
    {
        Players.Add(player);
    }
    
    public void RemovePlayer(IPlayer<BOARD,TURN> player)
    {
        Players.Remove(player);
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
        foreach (var player in Players)
        {
            CurrentPlayer = player;
            PlaySingleTurn();
        }
    }
    private void PlaySingleTurn()
    {
        if (IsGameOver()) return;
        ExecuteTurn();
        TerminateTurn( );
    }
    
    private void ExecuteTurn()
    {
        do
        {
            Turn = CurrentPlayer.DoTurn(Board);
        } while (TurnIsNotValid());
    }
    
    private void TerminateTurn( ) // Integration
    {
        UpdateBoard();
        PrintGameoverMessageIfGameIsOver();
    }
    
    private bool TurnIsNotValid()
    {
        if (IsTurnValid()) return false;
        Console.WriteLine("Ungueltiger Zug!");
        return true;
    }
    
    private void PrintGameoverMessageIfGameIsOver()
    {
        if (IsGameOver())
        {
            Console.WriteLine($"{CurrentPlayer.Name} hat verloren");
        }
    }
    
    // --------------------------------
    protected abstract bool IsGameOver();
    protected abstract bool IsTurnValid();
    protected abstract void UpdateBoard();
}