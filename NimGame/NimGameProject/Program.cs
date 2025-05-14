// See https://aka.ms/new-console-template for more information

using gi_de.client;
using gi_de.game;
using gi_de.game.nimgame;
using NimGame.gi_de.game.nimgame;

NimGameImpl game = new NimGameImpl();
game.AddPlayer(new HumanPlayer("Fritz"));
game.AddPlayer(new OmaPlayer("Gertrud"));
game.AddPlayer(new ComputerPlayer("HAL"));
GameClient client = new GameClient(game);

client.go();