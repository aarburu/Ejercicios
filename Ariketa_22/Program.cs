using Ariketa_22.Interfaces;
using Ariketa_22.Models;


var playerList = new List<IGameMember>();

Console.WriteLine("Sartu zure izena.");
var PlayerName = Console.ReadLine();

var player = new Player(PlayerName);
playerList.Add(player);


Console.WriteLine("Sartu ordenagailu kantitatea.");
var ComputerCount = int.Parse(Console.ReadLine());

for (int i = 0; i < ComputerCount; i++)
{
    var computer = new Computer($"Ordenagailua {i}");
    playerList.Add(computer);
}

do
{   
    var game = new Game(playerList);
    game.PlayRound();
    game.ShowScoreboard();
} while (!playerList.Any(p => p.Score >= 10));