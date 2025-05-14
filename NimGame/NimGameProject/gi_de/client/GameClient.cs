using gi_de.game;

namespace gi_de.client;

public class GameClient
{
    private readonly IGame _game;

    public GameClient(IGame game)
    {
        _game = game;
    }

    /// <summary>
    /// 
    /// </summary>
  
    public void go()
    {
        _game.Play();
    }
}