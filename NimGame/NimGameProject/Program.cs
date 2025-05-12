// See https://aka.ms/new-console-template for more information

using gi_de.client;
using gi_de.game;
using gi_de.game.nimgame;

IGame game = new NimGameImpl();
GameClient client = new GameClient(game);

client.go();