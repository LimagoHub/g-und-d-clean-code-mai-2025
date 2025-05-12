namespace gi_de.game.nimgame;

public class NimGameImpl: IGame
{

    private int _stones;
    private bool _gameOver;

    public NimGameImpl()
    {
        _stones = 23;
        _gameOver = false;
    }

    public void Play()
    {
        while (!_gameOver)
        {
            PlayRound();
        }
    }

    private void PlayRound()
    {
        HumanTurn();
        ComputerTurn();
    }


    private void HumanTurn()
    {
        int turn;
        while (true)
        {
            Console.WriteLine($"Es gibt {_stones} Steine. Bitte nehmen Sie 1, 2 oder 3!");
            var input = Console.ReadLine();
            turn = int.Parse(input);
            if (turn >= 1 && turn <= 3) break;
            Console.WriteLine("Ungueltiger Zug!");
        }

        _stones -= turn;
    }
    private void ComputerTurn()
    {
        int[] zuege ={3,1,1,2};
        int turn;

        if (_stones < 1)
        {
            _gameOver = true;
            Console.WriteLine("Du Loser!");
            return;
        }
        if (_stones == 1)
        {
            _gameOver = true;
            _stones = 0;
            Console.WriteLine("Du hast nur Glueck gehabt!");
            return;
        }
        turn = zuege[_stones % 4];
        Console.WriteLine($"Computer nimmt {turn} Steine.");
        _stones -= turn;
    }
}